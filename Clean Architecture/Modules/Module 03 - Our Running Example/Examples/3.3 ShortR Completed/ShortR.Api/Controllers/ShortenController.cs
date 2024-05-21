using Microsoft.AspNetCore.Mvc;
using ShortR.Contracts;

namespace ShortR.Api.Controllers;

[ApiController]
public class ShortenController : ControllerBase
{
    private readonly ILogger<ShortenController> _logger;

    public ShortenController(ILogger<ShortenController> logger)
    {
        _logger = logger;
    }

    [HttpPost("/shorten")]
    public async Task<IActionResult> ShortenAsync(ShortenRequestDto requestDto)
    {
        string resource = $"https://localhost:7044/goto/{requestDto.Code}";

        // TODO
        await Task.Delay(0);

        var result = new ShortenResponseDto
        {
            Id = Guid.NewGuid().ToString(),
            ResultingUrl = requestDto.LongUrl,
            Created = DateTime.Now
        };

        return Created(resource, result);
    }

    [HttpGet("/goto/{code}")]
    public async Task<IActionResult> GotoAsync(string code)
    {
        // TODO
        await Task.Delay(0);

        string url = "https://www.rammstein.de/de/konzerte/gelsenkirchen-27-07-2024";

        return Redirect(url);
    }
}
