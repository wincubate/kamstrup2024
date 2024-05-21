using MediatR;

namespace ShortR.Application.Queries.GetUrls;

public record class GetUrlsQuery : IRequest<GetUrlsQueryResult>
{
}
