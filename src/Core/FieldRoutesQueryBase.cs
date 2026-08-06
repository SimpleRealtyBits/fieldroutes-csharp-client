#nullable enable
namespace FieldRoutesApiClient.Core;

/// <summary>
/// Base class for all FieldRoutes search and bulk-get parameter objects.
/// Provides a <see cref="MaxResults"/> guard that defaults to 100 so callers
/// cannot accidentally return unbounded result sets and hammer the API.
/// Set to a higher value (or <see cref="int.MaxValue"/>) when you need more records.
/// </summary>
public abstract class FieldRoutesQueryBase
{
    /// <summary>
    /// Maximum number of results to return. Defaults to 100.
    /// For searches, limits the number of IDs included in the response.
    /// For bulk gets, limits the number of IDs sent to the API.
    /// </summary>
    public int MaxResults { get; set; } = 100;
}
