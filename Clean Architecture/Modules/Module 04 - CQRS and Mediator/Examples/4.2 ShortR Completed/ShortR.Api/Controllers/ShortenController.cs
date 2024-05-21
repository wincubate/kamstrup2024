using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShortR.Application.Commands.Shorten;
using ShortR.Application.Queries.Goto;
using ShortR.Contracts;

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
        var command = new ShortenCommand
        {
            Code = requestDto.Code,
            LongUrl = requestDto.LongUrl
        };
        var commandResult = await _mediator.Send(command);

        var responseDto = new ShortenResponseDto
        {
            Id = commandResult.ShortenedUrl.Id.ToString(),
            ResultingUrl = commandResult.ShortenedUrl.LongUri.ToString(),
            Created = commandResult.ShortenedUrl.Created
        };
        return Created(commandResult.ShortenedUrl.ShortUri.ToString(), responseDto);
    }

    [HttpGet("/goto/{code}")]
    public async Task<IActionResult> GotoAsync(string code, CancellationToken cancellationToken = default)
    {
        var query = new GotoQuery
        {
            Code = code
        };
        var queryResult = await _mediator.Send(query, cancellationToken);

        return Redirect(queryResult.LongUri.ToString());
    }
}
