using System;
using System.Net.Http;

namespace FieldRoutesApiClient.Core;

/// <summary>
/// Creates per-tenant <see cref="FieldRoutesApi"/> instances at runtime.
/// Users of a multi-tenant app supply their own FieldRoutes credentials, so
/// clients are created on demand (sign-up, login, background jobs) and simply
/// discarded when no longer needed — no per-tenant state is held.
/// </summary>
public interface IFieldRoutesClientFactory
{
    /// <summary>Creates a client for one tenant's credentials.</summary>
    FieldRoutesApi Create(FieldRoutesOptions options);

    /// <summary>Creates a client for one tenant's credentials.</summary>
    FieldRoutesApi Create(string baseUrl, string authenticationKey, string authenticationToken);
}

public sealed class FieldRoutesClientFactory : IFieldRoutesClientFactory
{
    // Shared across all tenants: authentication travels in the request body and
    // URLs are built per-tenant, so no per-tenant state exists on the HttpClient.
    private readonly HttpClient _http;

    public FieldRoutesClientFactory(HttpClient http) => _http = http;

    public FieldRoutesApi Create(FieldRoutesOptions options)
        => new FieldRoutesApi(_http, options);

    public FieldRoutesApi Create(string baseUrl, string authenticationKey, string authenticationToken)
        => Create(new FieldRoutesOptions
        {
            BaseUrl = baseUrl,
            AuthenticationKey = authenticationKey,
            AuthenticationToken = authenticationToken,
        });
}
