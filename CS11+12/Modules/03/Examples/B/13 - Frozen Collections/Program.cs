using System.Collections.Immutable;
using System.Collections.ObjectModel;

List<int> list = [11, 22, 33];
ReadOnlyCollection<int> readonlyList = list.AsReadOnly();
ImmutableList<int> immutableList = list.ToImmutableList();

//list.Add(44);

foreach (int i in immutableList)
{
    Console.WriteLine(i);
}

//FrozenSet<int> frozenSet = list.ToFrozenSet();
//if(frozenSet.TryGetValue(22, out int actualValue))
//{
//    Console.WriteLine($"Got {actualValue}");
//}

//FrozenDictionary<string, int> frozenDict = list.ToFrozenDictionary(
//    i => $"index {i}",
//    i => i
//);
//if (frozenDict.TryGetValue("index 22", out int value))
//{
//    Console.WriteLine($"Got {value} at \"index 22\"");
//}