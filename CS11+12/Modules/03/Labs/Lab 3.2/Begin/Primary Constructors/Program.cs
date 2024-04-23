var checking1 = new CheckingAccount(42);
Console.WriteLine(checking1.Number);       // Should print "10000000"
var checking2 = new CheckingAccount(0);
Console.WriteLine(checking2.Number);       // Should print "10000001"

var checking3 = new CheckingAccount(-87);  // Should throw BalanceException

