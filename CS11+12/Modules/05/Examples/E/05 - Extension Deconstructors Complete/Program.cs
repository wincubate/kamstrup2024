using Wincubate.Module05.Data.Persons;

var persons = new PersonRepository();

// Write the full name if length is more than 12, otherwise just "..."
var query = persons
    .GetAll()
    .Select( p => p switch
    {
        Person(int length, string fullName) when length > 12 => fullName,
        _ => "..."
    })
    ;

foreach (var result in query)
{
    Console.WriteLine(result);
}

static class MyPersonExtensions
{
    public static void Deconstruct(this Person person,
        out int length, out string fullName)
    {
        fullName = $"{person.FirstName} {person.LastName}";
        length = fullName.Length;
    }
}