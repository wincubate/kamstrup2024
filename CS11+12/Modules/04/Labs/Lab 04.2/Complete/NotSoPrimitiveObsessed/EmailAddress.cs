using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

partial record class EmailAddress
{
    [GeneratedRegex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$")]
    public static partial Regex GetValidationPattern();

    public static EmailAddress Parse(string value)
    {
        if( !GetValidationPattern().IsMatch(value))
        {
            throw new EmailAddressException(value);
        }

        return new EmailAddress(value);
    }

    public static bool TryParse(
        [NotNullWhen(true)] string? value, 
        [MaybeNullWhen(false)] out EmailAddress result )
    {
        string input = value ?? string.Empty;
        if (!GetValidationPattern().IsMatch(input))
        {
            result = new EmailAddress(input);
            return true;
        }
        else
        {
            result = null;
            return false;
        }
    }

    public static implicit operator string(EmailAddress emailAddress) =>
        emailAddress.Value;

    public string Value { get; }

    private EmailAddress(string value)
    {
        Value = value;
    }
}