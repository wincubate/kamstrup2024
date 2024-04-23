using System.Numerics;

var fibonacci = new Fibonacci()
    .Where(i => i % 4 == 0)
    .Take(20..30)
    ;
foreach (var i in fibonacci)
{
    Console.WriteLine(i);
}


class Fibonacci : IEnumerable<BigInteger>
{
    public IEnumerator<BigInteger> GetEnumerator()
    {
        BigInteger fib1 = 1;
        BigInteger fib2 = 1;

        yield return fib1;
        yield return fib2;

        while (true)
        {
            BigInteger f = fib1 + fib2;
            yield return f;

            fib1 = fib2;
            fib2 = f;
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
}