var elements = new string[]
{
    "Hello",
    "World",
    "Booyah"
};
var lookup = new LookupTable(elements, s => s.ToUpper());

Console.WriteLine(lookup.Get(2));


class LookupTable(string[] elements, Func<string, string> mapping)
{
    public string Get(Index index) => mapping(elements[index]);
}