using Wincubate.CS12.PrimaryConstructorsLab;

class CheckingAccount(decimal initialBalance) : BankAccount(GetNextAccountNumber().ToString(), initialBalance)
{
    private static ulong NextAccountNumber = 10_000_000;

    private static ulong GetNextAccountNumber() => NextAccountNumber++;

    public void Withdraw(decimal amount)
    {
        if( Balance < amount )
        {
            throw new BalanceException($"Balance too low");
        }

        Balance += amount;
    }
}

