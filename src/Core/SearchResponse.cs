using System.Collections.Generic;

namespace FieldRoutesApiClient.Core;

/// <summary>
/// Result of a search call. Field names are dynamic on the wire; the API echoes
/// <c>idName</c>, <c>propertyName</c> and <c>propertyNameData</c> meta fields which
/// this client uses to locate the ID array and (with includeData) the data array.
/// </summary>
public sealed class SearchResponse<T>
{
    /// <summary>IDs matching the search (the <c>idName</c> array).</summary>
    public List<int> IDs { get; init; } = new();

    /// <summary>Resolved entities, populated when includeData was requested.</summary>
    public List<T>? Data { get; init; }

    /// <summary>IDs beyond the first 1000 that were not exported as data.</summary>
    public List<int>? IDsNoDataExported { get; init; }

    /// <summary>Total number of matching IDs.</summary>
    public int Count { get; init; }

    /// <summary>Meta field echoed by the API: name of the ID array property.</summary>
    public string? IdName { get; init; }

    /// <summary>Meta field echoed by the API: name of the primary data property.</summary>
    public string? PropertyName { get; init; }

    /// <summary>Meta field echoed by the API: name of the includeData data property.</summary>
    public string? PropertyNameData { get; init; }
}
