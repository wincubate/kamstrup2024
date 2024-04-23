namespace Wincubate.Module05.Data.Persons;

public class Person
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }

    public static bool operator ==(Person? p1, Person? p2) =>
        (p1?.FirstName == p2?.FirstName) &&
        (p1?.LastName == p2?.LastName);

    public static bool operator !=(Person? p1, Person? p2) =>
        !(p1 == p2);

    public override bool Equals(object? obj) =>
        this == (obj as Person);

    public override int GetHashCode() =>
        (FirstName, LastName).GetHashCode();
}