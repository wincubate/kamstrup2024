namespace Wincubate.CS12.PrimaryConstructorsLab;

[Serializable]
public class BalanceException(string? message = null, Exception? inner = null)
    : BankException(message, inner)
{
}
