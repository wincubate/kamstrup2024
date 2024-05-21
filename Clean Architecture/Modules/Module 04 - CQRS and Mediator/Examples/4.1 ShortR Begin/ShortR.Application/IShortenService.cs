using ShortR.Domain;

namespace ShortR.Application;

public interface IShortenService
{
    Task<ShortenedUrl> ShortenAsync(string code, string longUrl);
    Task<Uri> LookupAsync(string code);
}
