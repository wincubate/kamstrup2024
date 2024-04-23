int x = 42;
int y = 87;

int tmp = x;
x = y;
y = tmp;
    
Console.WriteLine(x);
Console.WriteLine(y);

public class Person
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
}
