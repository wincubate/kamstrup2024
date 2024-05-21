using ErrorOr;
using MediatR;
using ShortR.Application.Common.Interfaces.Persistence;

namespace ShortR.Application.Commands.Delete;

internal class DeleteCommandHandler : IRequestHandler<DeleteCommand, ErrorOr<DeleteCommandResult>>
{
    private readonly IShortenedUrlRepository _repository;
    public DeleteCommandHandler(
        IShortenedUrlRepository repository
    )
    {
        _repository = repository;
    }

    public async Task<ErrorOr<DeleteCommandResult>> Handle(DeleteCommand command, CancellationToken cancellationToken)
    {
        var shortenedUrl = await _repository.GetByIdAsync(command.Id, cancellationToken);
        if (shortenedUrl is null)
        {
            string message = $"Code '{command.Id}' does not exist as a shortened URL";
            return Error.NotFound(description: message);
        }

        await _repository.RemoveAsync(shortenedUrl);

        var commandResult = new DeleteCommandResult();

        return commandResult;
    }
}
