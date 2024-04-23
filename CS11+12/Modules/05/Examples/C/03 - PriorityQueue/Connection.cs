namespace Wincubate.Module05.C;

record class Connection(string ClientId)
{
    public TimeOnly KeepAlive()
    {
        TimeOnly time = TimeOnly.FromDateTime(DateTime.Now);
        Console.WriteLine($"Keeping {ClientId} alive at {time.ToLongTimeString()}");

        return time;
    }
}
