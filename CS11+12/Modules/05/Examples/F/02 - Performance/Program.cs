using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<NumberExtractorBenchmarks>();

[RankColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[MemoryDiagnoser]
public class NumberExtractorBenchmarks
{
    const string Input = "2024,0042,0011,0087,0128,0176,0033,0022,0666,1981";

    readonly int[] valuesToFill = new int[10];
    [Benchmark(Baseline = true)]
    public void UsingArrays()
    {
        string[] arrayOfString = Input.Split(',');
        int length = arrayOfString.Length;
        for (int i = 0; i < length; i++)
        {
            valuesToFill[i] = int.Parse(arrayOfString[i]);
        }
    }

    readonly int[] valuesToFill2 = new int[10];
    [Benchmark()]
    public void UsingSpans()
    {
        ReadOnlySpan<char> span = Input.AsSpan();
        int nextCommaIndex = 0;
        int i = 0;
        bool isRunning = true;
        while (isRunning)
        {
            int start = nextCommaIndex;
            nextCommaIndex = Input.IndexOf(',', start);
            if(nextCommaIndex == -1)
            {
                isRunning = false;
                nextCommaIndex = Input.Length;
            }
            ReadOnlySpan<char> slice = span[start..nextCommaIndex];
            valuesToFill2[i++] = int.Parse(slice);

            nextCommaIndex++;
        }
    }
}