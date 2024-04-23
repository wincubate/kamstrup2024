using Wincubate.Module05.Data.Discography;

Album album = new Album(
    "Depeche Mode",
    "Violator",
    new DateTime(1990, 3, 19)
);

string description = album switch
{
    Album(_, string summary, int age) when age >= 25 => $"{summary} is vintage <3",
    Album(_, string summary, int age) when age >= 10 => $"{summary} is seasoned",
    Album(_, string summary, _) => $"{summary} is for youngsters only! ;-)"
};

Console.WriteLine(description);
