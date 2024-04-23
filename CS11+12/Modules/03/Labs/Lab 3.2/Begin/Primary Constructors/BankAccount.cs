using Wincubate.CS12.PrimaryConstructorsLab;

abstract class BankAccount
{
    // TODO

    public AccountNumberType Number { get; }
    public decimal Balance { get; private set; }
    
    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
}
