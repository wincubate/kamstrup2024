Console.WriteLine();

readonly ref struct Span<T>
{
    readonly ref T _field;
    readonly int _length;

    public Span(/*scoped*/ ref T value)
    {
        _field = ref value;
        _length = 1;
    }
}
