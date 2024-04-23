namespace Wincubate.CS12.PrimaryConstructorsLab;

[Serializable]
public abstract class BankException : Exception
{
    // TODO

    public BankException(string? message = null, Exception? inner = null)
        : base(message, inner)
    {
    }
}
