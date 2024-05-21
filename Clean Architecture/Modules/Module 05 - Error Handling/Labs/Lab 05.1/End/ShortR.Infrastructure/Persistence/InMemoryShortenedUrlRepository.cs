using ShortR.Application.Common.Interfaces.Persistence;
using ShortR.Domain;

namespace ShortR.Infrastructure.Persistence;

internal class InMemoryShortenedUrlRepository : IShortenedUrlRepository
{
    private static HashSet<ShortenedUrl> _shortenedUrls = [];

    public Task<bool> ExistsAsync(string code, CancellationToken cancellationToken)
    {
        return Task.FromResult(_shortenedUrls
            .Any(shortenedUrl => shortenedUrl.Code == code)
        );
    }

    public Task<ShortenedUrl?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.FromResult(_shortenedUrls
            .SingleOrDefault(shortenedUrl => shortenedUrl.Id == id)
        );
    }

    public Task<ShortenedUrl?> GetByCodeAsync(string code, CancellationToken cancellationToken)
    {
        return Task.FromResult(_shortenedUrls
            .SingleOrDefault(shortenedUrl => shortenedUrl.Code == code)
        );
    }

    public Task AddAsync(ShortenedUrl shortenedUrl)
    {
        _shortenedUrls.Add(shortenedUrl);

        return Task.CompletedTask;
    }

    public Task RemoveAsync(ShortenedUrl shortenedUrl)
    {
        _shortenedUrls.Remove(shortenedUrl);

        return Task.CompletedTask;
    }
}
