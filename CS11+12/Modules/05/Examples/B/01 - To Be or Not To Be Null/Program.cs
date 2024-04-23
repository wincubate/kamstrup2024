using Wincubate.Module05.Data.Persons;

void PrintEqualsNull(Person? p)
{
    if (p == null)
    {
        Console.WriteLine("p == null");
    }
    else
    {
        Console.WriteLine("p != null");
    }
}

void PrintIsNull(Person? p)
{
    if (p is null)
    {
        Console.WriteLine("p is null");
    }
    else
    {
        Console.WriteLine("p is not null");
    }
}

Person p = new()
{
    FirstName = "Bruce",
    LastName = "Campbell"
};

PrintEqualsNull(p);
PrintIsNull(p);
