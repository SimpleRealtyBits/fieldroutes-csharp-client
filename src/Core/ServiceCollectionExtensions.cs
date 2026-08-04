using Microsoft.Extensions.DependencyInjection;

namespace FieldRoutesApiClient.Core;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers the shared <see cref="HttpClient"/> and
    /// <see cref="IFieldRoutesClientFactory"/>. Resolve the factory and create a
    /// per-user <see cref="FieldRoutesApi"/> with that user's credentials —
    /// e.g. <c>factory.Create(options)</c>. The shared HttpClient is safe across
    /// tenants because authentication is carried in the request body and request
    /// URLs are built per tenant.
    /// </summary>
    public static IServiceCollection AddFieldRoutesClient(this IServiceCollection services)
    {
        services.AddSingleton<IFieldRoutesClientFactory, FieldRoutesClientFactory>();
        services.AddSingleton<HttpClient>();
        return services;
    }
}
