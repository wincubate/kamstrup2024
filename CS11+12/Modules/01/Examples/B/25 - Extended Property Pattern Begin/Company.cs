namespace Wincubate.CS10;

class Company
{
    public string Name { get; }
    public Company OwnedBy { get; }

    public Company(string name, Company ownedBy = default)
    {
        Name = name;
        OwnedBy = ownedBy;
    }
}
