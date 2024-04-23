namespace Wincubate.CS12.PrimaryConstructorsLab;

[Serializable]
public abstract class BankException(string? message = null, Exception? inner = null) : Exception(message, inner)
{
}
