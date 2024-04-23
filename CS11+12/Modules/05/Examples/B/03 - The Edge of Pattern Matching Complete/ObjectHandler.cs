namespace Wincubate.Module05.B;

public class ObjectHandler
{
    public static void Handle(bool o)
    {
        Console.WriteLine("Handling bool...\t" + o);
    }
    public static void Handle(int o)
    {
        Console.WriteLine("Handling int...\t\t" + o);
    }
    public static void Handle(double o)
    {
        Console.WriteLine("Handling double...\t" + o);
    }
    public static void Handle(string o)
    {
        Console.WriteLine("Handling string...\t" + o);
    }
    public static void Handle(object o)
    {
        Console.WriteLine("Handling object...\t" + o);
    }
}
