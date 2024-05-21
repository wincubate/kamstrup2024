using ShortR.Application.Commands.Delete;

namespace ShortR.Api.Controllers.Mapping;

internal static class DeleteRequestMapper
{
    public static DeleteCommand MapFrom(this Guid id) =>
        new()
        {
            Id = id
        };
}
