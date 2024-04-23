sealed class EmailAddressException(string emailAddress)
    : Exception($"Illegal email address \"{emailAddress}\"!")
{
    public string Value { get; } = emailAddress;
}
