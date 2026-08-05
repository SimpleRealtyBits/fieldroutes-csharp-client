using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FieldRoutesApiClient.Core;

/// <summary>
/// FieldRoutes emits dirty numerics in the wild: "" / "N/A" / "5.0" / "0" for
/// fields typed as numbers. Default handling throws on any of these; these
/// converters parse what is parseable and fall back to the type's default.
/// </summary>
internal static class FrJson
{
    public static readonly JsonSerializerOptions Options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString,
        Converters = { new TolerantInt32Converter(), new TolerantNullableInt32Converter(), new TolerantNullableDecimalConverter() },
    };
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
