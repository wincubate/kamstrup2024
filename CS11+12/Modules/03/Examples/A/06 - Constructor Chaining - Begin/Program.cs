var account = new BankAccount(42);
account.Deposit(87);
account.Deposit(112);

Console.WriteLine($"Balance is now {account.Balance:c}");

class BankAccount(decimal initialBalance)
{
    public decimal Balance { get; private set; } = initialBalance;

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
}
