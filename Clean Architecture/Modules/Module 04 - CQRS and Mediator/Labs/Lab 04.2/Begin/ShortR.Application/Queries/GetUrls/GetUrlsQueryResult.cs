using ShortR.Domain;

namespace ShortR.Application.Queries.GetUrls;

public record class GetUrlsQueryResult
{
    public required ShortenedUrl[] ShortenedUrls { get; init; }
}
