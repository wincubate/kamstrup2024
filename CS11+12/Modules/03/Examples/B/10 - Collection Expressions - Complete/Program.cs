List<string> elements = ["Hello", "World", "Booyah"];
var lookup = new LookupTable(elements, s => s.ToUpper());

Console.WriteLine(lookup.Get(2));


class LookupTable(List<string> elements, Func<string, string> mapping)
{
    public LookupTable() : this([], s => s) { }

    public string Get(Index index) => mapping(elements[index]);
}
