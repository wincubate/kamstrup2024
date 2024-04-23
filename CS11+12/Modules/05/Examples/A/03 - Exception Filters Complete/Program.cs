using Wincubate.Module05.Data.Banking;

var from = Bank.CreateAccount(100);
var to = Bank.CreateAccount(100);

try
{
    Bank.TransferFunds(from, 200, to);
}
catch (InsufficientFundsException e) when (e.Account is 
{ 
    IsVIP: true,
    Balance: >= 1000 and < 50000
})
{
    // Handle VIP account
}
catch (InsufficientFundsException)
{
    // Handle mere mortals' accounts
    throw;
}