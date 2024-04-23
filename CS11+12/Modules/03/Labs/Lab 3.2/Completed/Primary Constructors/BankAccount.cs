using Wincubate.CS12.PrimaryConstructorsLab;

abstract class BankAccount(string accountNumber, decimal initialBalance)
{
    public AccountNumberType Number { get; } = new(accountNumber);
    public decimal Balance { get; protected set; } = initialBalance >= 0
        ? initialBalance
        : throw new BalanceException($"Initial balance should be nonnegative: {initialBalance:c}")
        ;
    
    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
}

