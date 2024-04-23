var account = new BankAccount(42);
Console.WriteLine(account.Balance);

record class BankAccount(decimal Balance)
{
}
