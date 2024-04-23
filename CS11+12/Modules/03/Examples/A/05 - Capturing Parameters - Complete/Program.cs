var account = new BankAccount(42);
account.Deposit(87);
account.Deposit(112);
account.ChangeInitialBalance(666);

Console.WriteLine($"Balance is now {account.Balance:c} (was initially {account.InitialBalance:c})");

class BankAccount(decimal initialBalance)
{
    public decimal Balance { get; private set; } = initialBalance;
    public decimal InitialBalance => initialBalance;

    //private decimal initialBalance = initialBalance;

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void ChangeInitialBalance(decimal newInitialBalance)
    {
        initialBalance = newInitialBalance;
    }
}
