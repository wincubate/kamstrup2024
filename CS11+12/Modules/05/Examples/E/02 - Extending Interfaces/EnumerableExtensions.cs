namespace Wincubate.Module05.E;

static class EnumerableExtensions
{
    public static IEnumerable<T> Sample<T>(
        this IEnumerable<T> sequence,
        int frequency
    )
    {
        int i = 0;
        foreach (T item in sequence)
        {
            if (i++ % frequency == 0)
            {
                yield return item;
            }
        }
    }
}