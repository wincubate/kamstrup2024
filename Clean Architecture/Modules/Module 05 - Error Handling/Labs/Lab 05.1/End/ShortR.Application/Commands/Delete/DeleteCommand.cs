using ErrorOr;
using MediatR;

namespace ShortR.Application.Commands.Delete;

public record class DeleteCommand : IRequest<ErrorOr<DeleteCommandResult>>
{
    public required Guid Id { get; init; }
}
