using Microsoft.AspNetCore.Mvc;
using ShortR.Application;
using ShortR.Contracts;

namespace ShortR.Api.Controllers;

[ApiController]
public class ShortenController : ControllerBase
{
    private readonly ILogger<ShortenController> _logger;
    private readonly IShortenService _shortenService;

    public ShortenController(
        ILogger<ShortenController> logger,
        IShortenService shortenService
    )
    {
        _logger = logger;
        _shortenService = shortenService;
    }

    [HttpPost("/shorten")]
    public async Task<IActionResult> ShortenAsync(ShortenRequestDto requestDto)
    {
        string resource = $"https://localhost:7044/goto/{requestDto.Code}";

        var result = await _shortenService.ShortenAsync(
            requestDto.Code,
            requestDto.LongUrl
        );

        return Created(resource, result);
    }

    [HttpGet("/goto/{code}")]
    public async Task<IActionResult> GotoAsync(string code)
    {
        Uri uri = await _shortenService.LookupAsync(code);

        return Redirect(uri.ToString());
    }
}
