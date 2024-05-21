using ErrorOr;
using FluentValidation;
using FluentValidation.Results;
using MediatR;

namespace ShortR.Application.Commands.Shorten;

internal class ShortenCommandValidationBehaviour :
    IPipelineBehavior<ShortenCommand, ErrorOr<ShortenCommandResult>>
{
    private readonly IValidator<ShortenCommand> _validator;

    public ShortenCommandValidationBehaviour()
    {
        _validator = new ShortenCommandValidator();        
    }

    public async Task<ErrorOr<ShortenCommandResult>> Handle(ShortenCommand request, RequestHandlerDelegate<ErrorOr<ShortenCommandResult>> next, CancellationToken cancellationToken)
    {
        ValidationResult validationResult = await _validator.ValidateAsync(request, cancellationToken);
        if (validationResult.IsValid is false)
        {
            return validationResult.Errors
                .ConvertAll(error => Error.Validation(
                    code: error.PropertyName,
                    description: error.ErrorMessage
                ));
        }

        return await next();
    }
}
