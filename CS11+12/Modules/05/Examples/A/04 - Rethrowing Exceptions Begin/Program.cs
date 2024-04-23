try
{
    Computation.A();
}
catch (Exception exception)
{
    Console.WriteLine($"{exception.Message} [{exception.GetType().Name}]");
    Console.WriteLine(exception.StackTrace);
}
// Exiting program...



static class Computation
{
    public static void A()
    {
        try
        {
            B();
        }
        catch (DivideByZeroException exception)
        {
            throw exception;
        }

        Console.WriteLine("Exiting A");
    }

    public static void B()
    {
        C();

        Console.WriteLine("Exiting B");
    }

    public static void C()
    {
        int k = 87;
        int i = 100 / (k - 87);

        Console.WriteLine("Exiting C");
    }
}