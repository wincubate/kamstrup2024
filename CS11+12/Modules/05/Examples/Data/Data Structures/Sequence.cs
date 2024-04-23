namespace Wincubate.Module05.Data.DataStructures;

public sealed class Sequence<T>
{
    public SequenceElement<T>? Head { get; private set; }
    public SequenceElement<T>? Last { get; private set; }


    public Sequence()
    {
        Head = null;
        Last = null;
    }

    public void Add(T data)
    {
        SequenceElement<T> element = new(data);
        if (Head is null)
        {
            Head = element;
            Last = element;
        }
        else
        {
            Last!.Next = element;
            Last = Last.Next;
        }
    }
}