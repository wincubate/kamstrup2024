using Cinema.DataAccess.Sql;
using Cinema.Domain;

IMovieService service = new MovieService(
    new SqlMovieRepository(
        new MovieContext()
    )
);

// UI Layer
IEnumerable<MovieShowing> movies = service.GetMoviesShowing();
MainViewModel vm = new(movies);

foreach (MovieViewModel movie in vm.Movies)
{
    Console.WriteLine(movie.DisplayText);
}
