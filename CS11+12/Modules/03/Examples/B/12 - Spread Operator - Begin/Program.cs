int[] row0 = [1, 2, 3];
int[] row1 = [4, 5, 6];
int[] row2 = [7, 8, 9];

int[] all = [..row0, ..row1, ..row2];

foreach (var element in all)
{
    Console.WriteLine(element);
}




//List<string> elements = ["Hello", "World", "Booyah"];
//var lookup = new LookupTable(elements, s => s.ToUpper());

//Console.WriteLine(lookup.Get(2));

//class LookupTable(List<string> elements, Func<string, string> mapping)
//{
//    public LookupTable() : this([], s => s) { }

//    public string Get(Index index) => mapping(elements[index]);
//}
