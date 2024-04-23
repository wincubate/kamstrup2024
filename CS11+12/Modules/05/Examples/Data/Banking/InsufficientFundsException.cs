namespace Wincubate.Module05.Data.Banking;

[Serializable]
public class InsufficientFundsException : Exception
{
    public BankAccount Account { get; init; }

    public InsufficientFundsException(
        BankAccount account,
        string? message = null, 
        Exception? inner = null
    )
        : base(message, inner)
    {
        Account = account;
    }
}
