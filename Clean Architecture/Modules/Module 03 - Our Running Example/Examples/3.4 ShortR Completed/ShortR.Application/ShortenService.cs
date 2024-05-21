using ShortR.Application.Common.Exceptions;
using ShortR.Application.Common.Interfaces.Persistence;
using ShortR.Domain;

namespace ShortR.Application;

internal class ShortenService : IShortenService
{
    private readonly IShortenedUrlRepository _repository;
    private readonly Uri HOST = new("https://localhost:7044/goto/");

    public ShortenService(IShortenedUrlRepository repository)
    {
        _repository = repository;
    }

    public async Task<ShortenedUrl> ShortenAsync(string code, string longUrl)
    {
        if (await _repository.ExistsAsync(code))
        {
            string message = $"Code already exists as shortened URL";
            throw new AlreadyExistsException(code, message);
        }

        var shortenedUrl = new ShortenedUrl
        {
            Id = Guid.NewGuid(),
            Code = code,
            LongUri = new Uri(longUrl),
            ShortUri = new Uri(HOST, code),
            Created = DateTime.Now // <-- Argh!
        };
        await _repository.AddAsync(shortenedUrl);

        return shortenedUrl;
    }

    public async Task<Uri> LookupAsync(string code)
    {
        ShortenedUrl? shortenedUrl = await _repository.GetByCodeAsync(code);

        if (shortenedUrl is null)
        {
            string message = "Code does not exist as a shortened URL";
            throw new NotFoundException(code, message);
        }

        return shortenedUrl.LongUri;
    }
}
