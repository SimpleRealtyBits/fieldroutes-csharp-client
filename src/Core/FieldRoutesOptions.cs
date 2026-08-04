namespace FieldRoutesApiClient.Core;

/// <summary>Configuration for the FieldRoutes API client.</summary>
public sealed class FieldRoutesOptions
{
    /// <summary>
    /// Base URL of the FieldRoutes API, e.g. <c>https://demo.pestroutes.com/api/</c>.
    /// Accepts a bare domain (<c>https://demo.pestroutes.com</c>) as well.
    /// </summary>
    public string BaseUrl { get; set; } = "";

    /// <summary>API authentication key (Settings &gt; API in FieldRoutes).</summary>
    public string AuthenticationKey { get; set; } = "";

    /// <summary>API authentication token (Settings &gt; API in FieldRoutes).</summary>
    public string AuthenticationToken { get; set; } = "";
}
