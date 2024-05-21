using System.Text.Json.Serialization;

namespace ShortR.Contracts.GetUrls;

public record class UrlResponseDto
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("code")]
    public required string Code { get; init; }

    [JsonPropertyName("url")]
    public required string Url { get; init; }
}

public record class GetUrlsResponseDto
{
    [JsonPropertyName("urls")]
    public required UrlResponseDto[] Urls { get; init; }
}
