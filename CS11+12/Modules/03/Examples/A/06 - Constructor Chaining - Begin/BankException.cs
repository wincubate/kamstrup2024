namespace Wincubate.CS12;

[Serializable]
public class BankException : Exception
{
    public BankException(string? message = null, Exception? inner = null)
        : base(message, inner)
    {
    }
}
