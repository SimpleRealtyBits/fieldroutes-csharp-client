using System.Net.Http;

namespace FieldRoutesApiClient.Core;

public sealed partial class FieldRoutesApi
{
    private readonly FieldRoutesCore _core;

    /// <summary>Creates a client for one tenant's credentials (direct use, no DI needed).</summary>
    public FieldRoutesApi(FieldRoutesOptions options, HttpClient? http = null)
        => _core = new FieldRoutesCore(http ?? new HttpClient(), options);

    /// <summary>Internal; use <see cref="IFieldRoutesClientFactory"/> in DI scenarios.</summary>
    internal FieldRoutesApi(HttpClient http, FieldRoutesOptions options)
        => _core = new FieldRoutesCore(http, options);
}
