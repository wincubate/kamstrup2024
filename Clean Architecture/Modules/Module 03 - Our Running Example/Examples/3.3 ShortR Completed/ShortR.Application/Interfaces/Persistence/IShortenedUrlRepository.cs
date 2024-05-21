using ShortR.Domain;

namespace ShortR.Application.Interfaces.Persistence;

public interface IShortenedUrlRepository
{
    Task<bool> ExistsAsync(string code);
    Task<ShortenedUrl?> GetByCodeAsync(string code);
    Task AddAsync(ShortenedUrl shortenedUrl);
}
