namespace Wincubate.CS12.PrimaryConstructorsLab;

// This type should never be modified
readonly record struct AccountNumberType(string AccountNumber)
{
    public override string ToString() => AccountNumber.ToString();  
}

