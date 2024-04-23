using Wincubate.CS12;

var account = new NormalAccount(42);
account.Deposit(87);
account.Deposit(112);
account.Withdraw(176);
Console.WriteLine($"Balance is now {account.Balance:c}");

class BankAccount(decimal initialBalance)
{
    public decimal Balance { get; protected set; } = initialBalance;

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
}

class NormalAccount(decimal initialBalance, int additionalLimit = 0) : BankAccount(initialBalance)
{
    private readonly int _additionalLimit = additionalLimit;

    public NormalAccount() : this(0, 3_000)
    {
    }

    public void Withdraw(decimal amount)
    {
        if (Balance - amount > -_additionalLimit)
        {
            Balance -= amount;
        }

        throw new BankException($"Withdrawal limit exceeded");
    }
}

class VipAccount(decimal initialBalance) : NormalAccount(initialBalance, 5_000_000)
{ }
