using Wincubate.Module05.Data.Persons;

var persons = new PersonRepository();
var all = persons.GetAll();

// Write the full name if length is more than 12, otherwise just "..."

//var query = ???;

//foreach(var person in query)
//{
//    Console.WriteLine(person.???);
//}