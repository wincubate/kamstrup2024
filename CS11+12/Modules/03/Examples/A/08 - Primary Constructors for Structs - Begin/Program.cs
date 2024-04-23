Money m = new(87, 25);
Console.WriteLine(m);

struct Money
{
    public int Euro { get; init; }
    public int Cents { get; init; }

    public Money(int euro, int cents)
    {
        Euro = euro;
        Cents = cents;  
    }

    public override readonly string ToString() => $"EUR {Euro}:{Cents:d2}";
}

