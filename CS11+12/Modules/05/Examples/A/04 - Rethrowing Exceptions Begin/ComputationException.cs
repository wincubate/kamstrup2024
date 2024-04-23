namespace Wincubate.Module05.A;

[Serializable]
public class ComputationException : Exception
{
    public ComputationException(
        string? message = null,
        Exception? inner = null
    )
        : base(message, inner)
    {
    }
}
