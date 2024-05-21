using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShortR.Api.Controllers.Mapping;
using ShortR.Application.Queries.GetUrls;
using ShortR.Contracts.Shorten;

namespace ShortR.Api.Controllers;

[ApiController]
public class ShortenController : ControllerBase
{
    private readonly ILogger<ShortenController> _logger;
    private readonly IMediator _mediator;

    public ShortenController(
        ILogger<ShortenController> logger,
        IMediator mediator
    )
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpPost("/shorten")]
    public async Task<IActionResult> ShortenAsync(ShortenRequestDto requestDto)
    {
        var command = requestDto.MapFrom();
        var commandResult = await _mediator.Send(command);
        var (resource, responseDto) = commandResult.MapTo();
        
        return Created(resource, responseDto);
    }

    [HttpGet("/goto/{code}")]
    public async Task<IActionResult> GetUrlsAsync(string code, CancellationToken cancellationToken = default)
    {
        var query = code.MapFrom();
        var queryResult = await _mediator.Send(query, cancellationToken);
        string redirectTo = queryResult.MapTo();    

        return Redirect(redirectTo);
    }

    [HttpGet("/shortenedurls")]
    public async Task<IActionResult> GetUrlsAsync(CancellationToken cancellationToken = default)
    {
        var query = new GetUrlsQuery();
        var queryResult = await _mediator.Send(query, cancellationToken);
        var responseDto = queryResult.MapTo();

        return Ok(responseDto);
    }
}
