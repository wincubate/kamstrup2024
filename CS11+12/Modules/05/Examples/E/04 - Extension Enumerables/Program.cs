﻿using Wincubate.Module05.Data.DataStructures;

Sequence<int> sequence = new();
sequence.Add(42);
sequence.Add(87);
sequence.Add(112);

//foreach (var item in sequence)
//{
//    Console.WriteLine(item);
//}

//static class SequenceExtensions
//{
//    public static IEnumerator<T> GetEnumerator<T>(this Sequence<T> that)
//    {
//        SequenceElement<T>? current = that.Head;
//        while (current != null)
//        {
//            yield return current.Data;
//            current = current.Next;
//        }
//    }
//}