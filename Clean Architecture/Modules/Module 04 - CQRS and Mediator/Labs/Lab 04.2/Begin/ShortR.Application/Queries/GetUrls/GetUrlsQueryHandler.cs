using MediatR;
using ShortR.Application.Common.Interfaces.Persistence;
using ShortR.Domain;

namespace ShortR.Application.Queries.GetUrls;

internal class GetUrlsQueryHandler : IRequestHandler<GetUrlsQuery, GetUrlsQueryResult>
{
    private readonly IShortenedUrlRepository _repository;

    public GetUrlsQueryHandler(IShortenedUrlRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetUrlsQueryResult> Handle(GetUrlsQuery request, CancellationToken cancellationToken)
    {
        ShortenedUrl[] shortenedUrls = await _repository.GetAllAsync(cancellationToken);

        var queryResult = new GetUrlsQueryResult
        {
            ShortenedUrls = shortenedUrls
        };
        return queryResult;
    }
}
