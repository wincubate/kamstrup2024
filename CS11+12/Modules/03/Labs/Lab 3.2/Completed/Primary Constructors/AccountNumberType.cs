namespace Wincubate.CS12.PrimaryConstructorsLab;

readonly record struct AccountNumberType(string AccountNumber)
{
    public override string ToString() => AccountNumber.ToString();  
}

