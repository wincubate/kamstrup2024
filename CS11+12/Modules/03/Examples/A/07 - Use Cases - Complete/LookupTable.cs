namespace Wincubate.CS12;

class LookupTable(string[] elements, Func<string, string> mapping)
{
    public string Get(Index index) => mapping(elements[index]);
}