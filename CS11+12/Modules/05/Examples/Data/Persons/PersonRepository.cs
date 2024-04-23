namespace Wincubate.Module05.Data.Persons;

public class PersonRepository
{
    private readonly List<Person> _persons;

    public PersonRepository()
    {
        _persons = new List<Person>
        {
            new Person { FirstName = "Jimmy", LastName = "McGill" },
            new Person { FirstName = "Mike", LastName = "Ehrmantraut"},
            new Person { FirstName = "Tuco", LastName = "Salamanca"},
            new Person { FirstName = "Chuck", LastName = "McGill"}
        };
    }

    public IEnumerable<Person> GetAll() => _persons.ToList();

    public void Add(Person p) => _persons.Add(p);
}
