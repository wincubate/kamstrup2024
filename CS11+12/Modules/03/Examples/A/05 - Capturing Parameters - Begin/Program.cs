var account = new BankAccount(42);
account.Deposit(87);
Console.WriteLine(account.Balance);

partial class BankAccount(decimal initialBalance)
{
    public decimal Balance { get; private set; } = initialBalance;

    public void Deposit(decimal amount) => Balance += amount;
}
