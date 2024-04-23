Money m = new();
Console.WriteLine(m);

struct Money(int euro, int cents)
{
    public int Euro { get; init; } = euro;
    public int Cents { get; init; } = cents;

    public override readonly string ToString() => $"EUR {Euro}:{Cents:d2}";
}

