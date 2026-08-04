using System;

namespace FieldRoutesApiClient.Core;

/// <summary>Thrown when the FieldRoutes API returns a non-success HTTP status or an error envelope.</summary>
public sealed class FieldRoutesApiException : Exception
{
    public int StatusCode { get; }

    public string? ResponseBody { get; }

    public FieldRoutesApiException(int statusCode, string? responseBody, string message)
        : base(message)
    {
        StatusCode = statusCode;
        ResponseBody = responseBody;
    }
}
