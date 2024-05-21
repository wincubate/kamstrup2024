namespace ShortR.Contracts.GetUrls;

public record class UrlResponseDto
{
    public required string Id { get; init; }
    public required string Code { get; init; }
    public required string Url { get; init; }
}

public record class GetUrlsResponseDto
{
    public required UrlResponseDto[] Urls { get; init; }
}
