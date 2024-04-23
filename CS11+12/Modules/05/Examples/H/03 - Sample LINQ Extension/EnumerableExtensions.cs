using System.Runtime.CompilerServices;

namespace Wincubate.Module05.H;

static class EnumerableExtensions
{
    public static IEnumerable<T> Sample<T>(
        this IEnumerable<T> sequence,
        int frequency,
        [CallerArgumentExpression(nameof(sequence))] string? message = null)
    {
        if (sequence.Count() < frequency)
        {
            throw new ArgumentException(
                $"Expression doesn't have enough elements:{Environment.NewLine}{message}",
                nameof(sequence)
            );
        }

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