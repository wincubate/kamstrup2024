namespace Wincubate.CS12;

[Serializable]
public class BankException(string? message = null, Exception? inner = null)
    : Exception(message, inner)
{
}
