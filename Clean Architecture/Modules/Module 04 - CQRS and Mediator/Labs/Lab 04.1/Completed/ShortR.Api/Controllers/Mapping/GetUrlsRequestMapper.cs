using ShortR.Application.Queries.GetUrls;
using ShortR.Contracts.GetUrls;
using ShortR.Domain;

namespace ShortR.Api.Controllers.Mapping;

internal static class GetUrlsRequestMapper
{
    public static GetUrlsResponseDto MapTo(this GetUrlsQueryResult queryResult) =>
        new()
        {
            Urls = queryResult.ShortenedUrls
                .Select(MapTo)
                .ToArray()
        };

    public static UrlResponseDto MapTo(this ShortenedUrl shortenedUrl) =>
        new()
        {
            Id = shortenedUrl.Id.ToString(),
            Code = shortenedUrl.Code,
            Url = shortenedUrl.LongUri.ToString()
        };
}
