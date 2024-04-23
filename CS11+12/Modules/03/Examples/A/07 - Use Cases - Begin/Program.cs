using Wincubate.CS12;

var elements = new string[]
{
    "Hello",
    "World",
    "Booyah"
};
var lookup = new LookupTable(elements, s => s.ToUpper());

Console.WriteLine(lookup.Get(2));