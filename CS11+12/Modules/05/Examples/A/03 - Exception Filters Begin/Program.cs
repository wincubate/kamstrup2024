using Wincubate.Module05.Data.Banking;

var from = Bank.CreateAccount(100);
var to = Bank.CreateAccount(100);

try
{
    Bank.TransferFunds(from, 200, to);
}
catch (InsufficientFundsException e)
{
    if (e.Account.IsVIP == true)
    {
        // Handle VIP account
    }
    else
    {
        throw;
    }
}
