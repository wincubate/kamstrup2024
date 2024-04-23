using System.Collections;

namespace Wincubate.Module05.E;

public class SequencePacker<T> : IEnumerable<T> where T : IEquatable<T>
{
    private class Node<TElement>
    {
        public Node(TElement t, int aggregatedBlockIndex, int count = 1)
        {
            Element = t;
            AggregatedBlockIndex = aggregatedBlockIndex;
            Count = count;
        }

        public TElement Element { get; set; }
        public int Count { get; set; }
        public int AggregatedBlockIndex { get; private set; }
    }

    private readonly List<Node<T>> _nodes;

    public int Count { get => _aggregatedCount; }
    private int _aggregatedCount;

    #region Helpers

    private void EnsureIndexExists(Index index)
    {
        if (index.IsFromEnd == false)
        {
            // From Start
            if (index.Value < 0 || index.Value >= _aggregatedCount)
            {
                throw new IndexOutOfRangeException($"{index} out of range for {nameof(SequencePacker<T>)}");
            }
        }
        else
        {
            // From End
            if (index.Value <= 0 || index.Value > _aggregatedCount)
            {
                throw new IndexOutOfRangeException($"{index} out of range for {nameof(SequencePacker<T>)}");
            }
        }
    }

    private (int nodeIndex, Node<T> node) FindNodeForIndex(Index index)
    {
        int i;
        if (index.IsFromEnd == false)
        {
            int value = index.Value;

            i = 0;
            while (_nodes[i].AggregatedBlockIndex + _nodes[i].Count <= value)
            {
                i++;
            }
        }
        else
        {
            int value = index.Value;

            int totalCount = Count;
            i = _nodes.Count - 1;
            while (totalCount - _nodes[i].AggregatedBlockIndex < value)
            {
                i--;
            }
        }
        return (i, _nodes[i]);
    }

    #endregion

    #region Indices and Ranges

    public T this[Index index]
    {
        get
        {
            EnsureIndexExists(index);
            (_, Node<T> node) = FindNodeForIndex(index);
            return node.Element;
        }
    }

    public SequencePacker<T> this[Range range]
    {
        get
        {
            EnsureIndexExists(range.Start);
            int startOffset = range.Start.GetOffset(Count);
            int endOffset = range.End.GetOffset(Count);

            SequencePacker<T> sliced = new SequencePacker<T>();
            foreach (var element in this
                .Skip(startOffset)
                .Take(endOffset - startOffset))
            {
                sliced.Add(element);
            }

            return sliced;
        }
    }

    #endregion

    public SequencePacker()
    {
        _nodes = [];
        _aggregatedCount = 0;
    }

    public void Clear()
    {
        _nodes.Clear();
    }

    public void Add(T t)
    {
        bool handled = false;
        if (_nodes.Count > 0)
        {
            Node<T> lastNode = _nodes[^1];
            if (lastNode.Element.Equals(t))
            {
                lastNode.Count++;
                handled = true;
            }
        }

        if (handled == false)
        {
            _nodes.Add(new Node<T>(t, _aggregatedCount));
        }

        _aggregatedCount++;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (Node<T> node in _nodes)
        {
            for (int i = 0; i < node.Count; i++)
            {
                yield return node.Element;
            }
        }
    }
}
