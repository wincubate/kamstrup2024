using Wincubate.CS11.Labs;

// This should compile!
User user1 = new()
{
	FullName = "Robert G. Tapert",
    UserId = Guid.NewGuid(),
    IsActive = false,
};
Console.WriteLine(user1);

Console.WriteLine(new string('.', 80));

// This should compile!
User user2 = new("Bruce Campbell")
{
	IsActive = true,
};
Console.WriteLine(user2);

Console.WriteLine(new string('.',80));

// This should compile!
User user3 = new("Sam Raimi")
{
	UserId = Guid.NewGuid(),
	Company = "Spiders 'R Us",
    IsActive = null,
};
Console.WriteLine(user3);

Console.WriteLine(new string('.', 80));

// This should *not* compile!
//User user4 = new()
//{
//    UserId = Guid.NewGuid(),
//    IsActive = false,
//};
//Console.WriteLine(user4);

// This should *not* compile!
//User user5 = new()
//{
//	FullName = "Kevin Costner",
//    IsActive = false,
//};
//Console.WriteLine(user5);

// This should *not* compile!
//User user6 = new()
//{
//	FullName = "Mary McDonnell",
//    UserId = Guid.NewGuid(),
//};
//Console.WriteLine(user6);
