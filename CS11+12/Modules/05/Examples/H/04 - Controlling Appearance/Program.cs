using System.Diagnostics;

IEnumerable<Movie> movies = new List<Movie>
{
    new("Total Recall", 2012, 6.2f),
    new("Evil Dead", 1981, 7.5f),
    new("The Matrix", 1999, 8.7f),
    new("Cannonball Run", 1981, 6.3f),
    new("Star Wars: Episode IV - A New Hope", 1977, 8.6f),
    new("Don't Look Up", 2021, 7.3f),
    new("Evil Dead", 2013, 6.5f),
    new("Who Am I", 2014, 7.5f),
    new("Total Recall", 1990, 7.5f),
    new("The Interview", 2014, 6.5f)
};

IEnumerable<Movie> queryE = movies
    .OrderBy(movie => movie.Year)
    .DistinctBy(movie => movie.Title)
    ;
foreach (Movie movie in queryE)
{
    Console.WriteLine(movie);
}


[DebuggerDisplay("{Title} {ImdbRating} [{Year}]")]
public record class Movie(string Title, int Year, float ImdbRating);
