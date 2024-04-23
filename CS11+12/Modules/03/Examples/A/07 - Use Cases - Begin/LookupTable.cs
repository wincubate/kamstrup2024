namespace Wincubate.CS12;

class LookupTable
{
    private readonly string[] _elements;
    private readonly Func<string,string> _mapping;

    public LookupTable(string[] elements, Func<string, string> mapping)
    {
        _elements = elements;
        _mapping = mapping;
    }

    public string Get(Index index)
    {
        return _mapping(_elements[index]);
    }
}