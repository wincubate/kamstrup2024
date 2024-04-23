using Wincubate.Module05.A;

try
{
    A();
}
catch (Exception exception)
{
    Console.WriteLine($"{exception.Message} [{exception.GetType().Name}]");
    Console.WriteLine(exception.StackTrace);
}
// Exiting program...



static void A()
{
    try
    {
        B();
    }
    catch (DivideByZeroException e)
    {
        throw new ComputationException("Oh no", e);
    }

    Console.WriteLine("Exiting A");
}

static void B()
{
    C();

    Console.WriteLine("Exiting B");
}

static void C()
{
    int k = 87;
    int i = 100 / (k - 87);

    Console.WriteLine("Exiting C");
}
