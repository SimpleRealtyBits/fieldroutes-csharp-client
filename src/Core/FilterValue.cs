namespace FieldRoutesApiClient.Core;

/// <summary>
/// A search query object. The FieldRoutes API accepts either a simple value for a
/// search parameter or a query object with an operator.
/// </summary>
/// <param name="Operator">
/// One of: &gt;, &lt;, &gt;=, &lt;=, =, !=, IN, BETWEEN, LIKE, STARTSWITH, ENDSWITH, CONTAINS.
/// </param>
/// <param name="Value">Operand; an array for BETWEEN and IN.</param>
public sealed record FilterValue(string Operator, object? Value);
