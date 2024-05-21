using FluentValidation;
using ShortR.Application.Queries.Goto;

namespace ShortR.Application.Commands.Goto;

public class GotoQueryValidator : AbstractValidator<GotoQuery>
{
    public GotoQueryValidator()
    {
        RuleFor(command => command.Code)
            .Matches(@"[a-zA-Z0-9]{5,30}")
            ;
    }
}
