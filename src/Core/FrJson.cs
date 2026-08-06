using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FieldRoutesApiClient.Core;

/// <summary>
/// FieldRoutes emits dirty numerics in the wild: "" / "N/A" / "5.0" / "0" for
/// fields typed as numbers. Default handling throws on any of these; these
/// converters parse what is parseable and fall back to the type's default.
///
/// MANUAL FIX (2026-08-05): this whole file exists because FieldRoutes wire data
/// does not match its own docs (see the // MANUAL FIX comments in the models).
/// Keep every converter here tolerant — a dirty response must never crash a
/// bulk deserialization.
/// </summary>
internal static class FrJson
{
    public static readonly JsonSerializerOptions Options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString,
        Converters = { new TolerantStringConverter(), new TolerantInt32Converter(), new TolerantNullableInt32Converter(), new TolerantNullableDecimalConverter(), new TolerantInt32ArrayConverter() },
    };
}

/// <summary>
/// FieldRoutes sometimes emits a non-string token (number, bool, JSON array or
/// object) for a property typed as a string. Default handling throws
/// "Cannot get the value of a token type 'X' as a string"; this converter
/// returns the raw JSON text instead (or null for JSON null), so a dirty
/// response can never crash a bulk deserialization. Strings pass through
/// unchanged.
/// </summary>
/// <remarks>
/// MANUAL FIX (2026-08-05): added after a live bulk get failed with
/// "Cannot get the value of a token type 'StartArray' as a string" — some
/// string-typed properties (e.g. customerLink, scheduleTeams on older data)
/// can arrive as arrays. Raw JSON text preserves the value for inspection
/// instead of losing it.
/// </remarks>
internal sealed class TolerantStringConverter : JsonConverter<string?>
{
    public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String) return reader.GetString();
        if (reader.TokenType == JsonTokenType.Null) return null;
        using var doc = JsonDocument.ParseValue(ref reader);
        return doc.RootElement.GetRawText();
    }

    public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
    {
        if (value is null) writer.WriteNullValue();
        else writer.WriteStringValue(value);
    }
}

internal sealed class TolerantNullableDecimalConverter : JsonConverter<decimal?>
{
    public override decimal? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Number) return reader.GetDecimal();
        if (reader.TokenType == JsonTokenType.Null) return null;
        if (reader.TokenType == JsonTokenType.String)
        {
            var s = reader.GetString();
            return string.IsNullOrWhiteSpace(s) || !decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out var d)
                ? null : d;
        }
        throw new JsonException($"Unexpected token {reader.TokenType} for Decimal?.");
    }

    public override void Write(Utf8JsonWriter writer, decimal? value, JsonSerializerOptions options)
    {
        if (value.HasValue) writer.WriteNumberValue(value.Value);
        else writer.WriteNullValue();
    }
}

internal sealed class TolerantInt32Converter : JsonConverter<int>
{
    public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Number) return reader.GetInt32();
        if (reader.TokenType == JsonTokenType.Null) return 0;
        if (reader.TokenType == JsonTokenType.String)
            return FrNumeric.ParseInt(reader.GetString()) ?? 0;
        throw new JsonException($"Unexpected token {reader.TokenType} for Int32.");
    }

    public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        => writer.WriteNumberValue(value);
}

internal sealed class TolerantNullableInt32Converter : JsonConverter<int?>
{
    public override int? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Number) return reader.GetInt32();
        if (reader.TokenType == JsonTokenType.Null) return null;
        if (reader.TokenType == JsonTokenType.String) return FrNumeric.ParseInt(reader.GetString());
        throw new JsonException($"Unexpected token {reader.TokenType} for Int32?.");
    }

    public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
    {
        if (value.HasValue) writer.WriteNumberValue(value.Value);
        else writer.WriteNullValue();
    }
}

/// <summary>
/// Accepts JSON arrays of ints (elements may be numbers or numeric strings),
/// a bare number, or a comma-separated string, for properties the API docs
/// type as integer but that are lists on the wire.
/// </summary>
/// <remarks>
/// MANUAL FIX (2026-08-05): several api.md "integer" fields are JSON arrays in
/// reality (subscriptionIDs, appointmentIDs, unitIDs, additionalTechs,
/// invoiceIDs, ...) and have been observed as comma-separated strings too.
/// Registered globally so any int[]-typed model property parses all three
/// shapes. Semantics mirror TolerantInt32Converter: garbage element -> 0,
/// null element -> 0, empty/absent -> null.
/// </remarks>
internal sealed class TolerantInt32ArrayConverter : JsonConverter<int[]>
{
    public override int[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        switch (reader.TokenType)
        {
            case JsonTokenType.Null:
                return null;
            case JsonTokenType.Number:
                return new[] { reader.GetInt32() };
            case JsonTokenType.String:
                return ParseCsv(reader.GetString());
            case JsonTokenType.StartArray:
                var list = new List<int>();
                while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    switch (reader.TokenType)
                    {
                        case JsonTokenType.Null:
                            list.Add(0);
                            break;
                        case JsonTokenType.Number:
                            list.Add(reader.GetInt32());
                            break;
                        case JsonTokenType.String:
                            list.Add(FrNumeric.ParseInt(reader.GetString()) ?? 0);
                            break;
                        default:
                            throw new JsonException($"Unexpected token {reader.TokenType} in Int32 array.");
                    }
                }
                return list.ToArray();
            default:
                throw new JsonException($"Unexpected token {reader.TokenType} for Int32 array.");
        }
    }

    public override void Write(Utf8JsonWriter writer, int[] value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        foreach (var v in value) writer.WriteNumberValue(v);
        writer.WriteEndArray();
    }

    /// <summary>FieldRoutes sometimes emits a comma-separated string ("1,2,3") instead of an array.</summary>
    private static int[]? ParseCsv(string? s)
    {
        if (string.IsNullOrWhiteSpace(s)) return null;
        var list = new List<int>();
        foreach (var part in s.Split(','))
        {
            if (string.IsNullOrWhiteSpace(part)) continue;
            list.Add(FrNumeric.ParseInt(part) ?? 0);
        }
        return list.ToArray();
    }
}

internal static class FrNumeric
{
    /// <summary>Parse a string as Int32, tolerating decimals ("12.0") and garbage ("" → null).</summary>
    public static int? ParseInt(string? s)
    {
        if (string.IsNullOrWhiteSpace(s)) return null;
        if (int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out var v)) return v;
        if (decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out var d) && d == Math.Truncate(d))
            return d >= int.MinValue && d <= int.MaxValue ? (int)d : null;
        return null;
    }
}
