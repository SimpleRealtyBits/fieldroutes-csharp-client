using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace FieldRoutesApiClient.Core;

/// <summary>
/// Internal HTTP transport for the FieldRoutes API. Every endpoint is a POST to
/// <c>{base}/{entity}/{action}</c> with the authentication key/token in the body
/// (this is how the official FieldRoutes client authenticates — no headers).
/// Responses are wrapped in a <c>{success, result, errorMessage}</c> envelope,
/// except search responses which expose dynamic <c>idName</c>/<c>propertyName</c>
/// meta fields; both are handled here.
/// </summary>
internal sealed class FieldRoutesCore
{
    private readonly HttpClient _http;
    private readonly Uri _base;

    public FieldRoutesCore(HttpClient http, FieldRoutesOptions options)
    {
        _http = http;
        _base = new Uri(NormalizeBase(options.BaseUrl));
        _optionsKey = options.AuthenticationKey ?? throw new ArgumentException(
            "FieldRoutesOptions.AuthenticationKey is required.", nameof(options));
        _optionsToken = options.AuthenticationToken ?? throw new ArgumentException(
            "FieldRoutesOptions.AuthenticationToken is required.", nameof(options));
    }

    internal static string NormalizeBase(string url)
    {
        var u = (url ?? "").Trim().TrimEnd('/');
        if (u.Length == 0)
            throw new ArgumentException("FieldRoutesOptions.BaseUrl is required.", nameof(url));
        return u.EndsWith("/api", StringComparison.OrdinalIgnoreCase) ? u + "/" : u + "/api/";
    }

    private Dictionary<string, object?> BuildBody(IDictionary<string, object?>? parameters)
    {
        var body = new Dictionary<string, object?>
        {
            ["authenticationKey"] = _optionsKey,
            ["authenticationToken"] = _optionsToken,
        };
        if (parameters is not null)
            foreach (var (k, v) in parameters)
                body[k] = v;
        return body;
    }

    // Auth values cached at construction so options mutations after registration are ignored.
    private readonly string _optionsKey;
    private readonly string _optionsToken;

    private Uri Path(string entity, string action) => new(_base, $"{entity}/{action}");

    private static async Task<(int Status, string Text)> SendAsync(
        HttpClient http, Uri uri, Dictionary<string, object?> body, CancellationToken ct)
    {
        using var resp = await http.PostAsJsonAsync(uri, body, FrJson.Options, ct).ConfigureAwait(false);
        var text = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);
        return ((int)resp.StatusCode, text);
    }

    private static void EnsureSuccess(int status, string text)
    {
        if (status < 200 || status >= 300)
            throw new FieldRoutesApiException(status, text, $"FieldRoutes API returned HTTP {(int)status}.");
    }

    private static void EnsureEnvelopeOk(int status, string text, JsonElement root)
    {
        if (root.ValueKind != JsonValueKind.Object || !root.TryGetProperty("success", out var success))
            return; // no envelope; raw payload
        if (!ReadBool(success))
        {
            var msg = root.TryGetProperty("errorMessage", out var em) ? em.GetString() : null;
            throw new FieldRoutesApiException(status, text, msg ?? "FieldRoutes API returned success=false.");
        }
    }

    private static bool ReadBool(JsonElement e) => e.ValueKind switch
    {
        JsonValueKind.True => true,
        JsonValueKind.False => false,
        JsonValueKind.Number => e.GetInt32() != 0,
        JsonValueKind.String => bool.TryParse(e.GetString(), out var b) && b || e.GetString() == "1",
        _ => false,
    };

    /// <summary>
    /// Deserialize with tolerant options; on JsonException rethrow as a
    /// FieldRoutesApiException that names the entity/action and the exact JSON
    /// property path so a real-data type mismatch is immediately diagnosable.
    /// </summary>
    /// <remarks>
    /// MANUAL FIX (2026-08-05): a live bulk get failed with a bare JsonException
    /// ("Cannot get the value of a token type 'StartArray' as a string") that gave
    /// no entity or property context. Wrapping here means the NEXT real-data
    /// mismatch reports e.g. "Failed to deserialize appointment/get: ... Path:
    /// $[0].additionalTechs". The wire-cased property name appears in Path
    /// (JsonException.Path), not the C# property name.
    /// </remarks>
    private static T DeserializeSafe<T>(string entity, string action, JsonElement element, int status, string text)
    {
        try
        {
            return element.Deserialize<T>(FrJson.Options)!;
        }
        catch (JsonException ex)
        {
            throw new FieldRoutesApiException(status, text,
                $"Failed to deserialize {entity}/{action}: {ex.Message} Path: {ex.Path ?? "(unknown)"}");
        }
    }

    /// <summary>POST an entity action and deserialize the result (envelope-aware).</summary>
    public async Task<T> PostAsync<T>(string entity, string action, IDictionary<string, object?>? parameters, CancellationToken ct)
    {
        var (status, text) = await SendAsync(_http, Path(entity, action), BuildBody(parameters), ct).ConfigureAwait(false);
        EnsureSuccess(status, text);
        using var doc = JsonDocument.Parse(text);
        var root = doc.RootElement;
        EnsureEnvelopeOk(status, text, root);
        if (root.ValueKind == JsonValueKind.Object && root.TryGetProperty("result", out var result))
            return result.ValueKind == JsonValueKind.Null ? default! : DeserializeSafe<T>(entity, action, result, status, text);
        // Some get endpoints (e.g. office/get) return the records under a plural key
        // ({success, offices:[...]}) instead of the result envelope. Mirrors the official
        // client's response[type + 's'] unwrap. Only applies when a list is expected.
        // MANUAL FIX (2026-08-05): documented here because it deviates from the api.md
        // envelope shape — always check both shapes when adding a new bulk get path.
        if (root.ValueKind == JsonValueKind.Object
            && typeof(T).IsGenericType && typeof(T).GetGenericTypeDefinition() == typeof(List<>)
            && root.TryGetProperty(entity + "s", out var plural) && plural.ValueKind == JsonValueKind.Array)
            return DeserializeSafe<T>(entity, action, plural, status, text);
        return DeserializeSafe<T>(entity, action, root, status, text);
    }

    /// <summary>
    /// POST a search and parse the dynamic-key search response. Accepts every
    /// envelope shape FieldRoutes emits in the wild (meta keys at the root, or
    /// wrapped under <c>result</c> with or without meta keys).
    /// </summary>
    public async Task<SearchResponse<T>> PostSearchAsync<T>(string entity, IDictionary<string, object?>? parameters, CancellationToken ct)
    {
        var (status, text) = await SendAsync(_http, Path(entity, "search"), BuildBody(parameters), ct).ConfigureAwait(false);
        EnsureSuccess(status, text);
        using var doc = JsonDocument.Parse(text);
        var root = doc.RootElement;
        EnsureEnvelopeOk(status, text, root);

        // FieldRoutes is inconsistent about where the search payload lives:
        //   a) meta keys at the envelope root: {"success":true,"idName":"customerIDs","customerIDs":[...],...}
        //   b) payload wrapped under "result" WITH meta keys:
        //      {"success":true,"result":{"idName":"routeIDs","propertyName":"routes","routeIDs":[...],"routes":[...]}}
        //   c) payload wrapped under "result" WITHOUT meta keys: {"success":true,"result":{"routeIDs":[...]}}
        // MANUAL FIX (2026-08-05): previously we only descended into "result" when it had NO
        // idName (shape c), so the real shape (b) was parsed against the outer envelope and
        // returned empty IDs — Routes.SearchAsync showed zero routes while offices parsed fine.
        // Parse all three from a single chosen payload root; the existing fallbacks
        // (FirstKeyEndingWith, propertyName candidates, NoDataExported) then operate on it.
        var payload = root.ValueKind == JsonValueKind.Object
            && root.TryGetProperty("result", out var result)
            && result.ValueKind == JsonValueKind.Object
                ? result
                : root;

        var idName = GetString(payload, "idName")
            ?? FirstKeyEndingWith(payload, "IDs", exclude: "NoDataExported");
        var propertyName = GetString(payload, "propertyName");
        var propertyNameData = GetString(payload, "propertyNameData");

        var ids = new List<int>();
        if (idName is not null && payload.TryGetProperty(idName, out var idEl) && idEl.ValueKind == JsonValueKind.Array)
            ids = DeserializeSafe<List<int>>(entity, "search", idEl, status, text) ?? new List<int>();

        List<T>? data = null;
        foreach (var candidate in new[] { propertyNameData, propertyName })
        {
            if (candidate is null || candidate == idName) continue;
            if (payload.TryGetProperty(candidate, out var dataEl) && dataEl.ValueKind == JsonValueKind.Array)
            {
                data = DeserializeSafe<List<T>>(entity, "search", dataEl, status, text);
                break;
            }
        }

        List<int>? noData = null;
        if (idName is not null && payload.TryGetProperty(idName + "NoDataExported", out var ndEl) && ndEl.ValueKind == JsonValueKind.Array)
            noData = DeserializeSafe<List<int>>(entity, "search", ndEl, status, text);

        return new SearchResponse<T>
        {
            IDs = ids,
            Data = data,
            IDsNoDataExported = noData,
            Count = GetInt(payload, "count") ?? ids.Count,
            IdName = idName,
            PropertyName = propertyName,
            PropertyNameData = propertyNameData,
        };
    }

    private static string? GetString(JsonElement root, string name) =>
        root.ValueKind == JsonValueKind.Object && root.TryGetProperty(name, out var e)
            ? e.ValueKind == JsonValueKind.String ? e.GetString() : null
            : null;

    private static int? GetInt(JsonElement root, string name) =>
        root.ValueKind == JsonValueKind.Object && root.TryGetProperty(name, out var e)
            ? e.ValueKind == JsonValueKind.Number ? e.GetInt32() : null
            : null;

    private static string? FirstKeyEndingWith(JsonElement root, string suffix, string exclude)
    {
        if (root.ValueKind != JsonValueKind.Object) return null;
        foreach (var prop in root.EnumerateObject())
        {
            if (prop.Name.EndsWith(suffix, StringComparison.Ordinal) && !prop.Name.Contains(exclude))
                return prop.Name;
        }
        return null;
    }
}
