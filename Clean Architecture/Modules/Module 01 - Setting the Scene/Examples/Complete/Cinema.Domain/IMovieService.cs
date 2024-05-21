namespace Cinema.Domain;

public interface IMovieService
{
    IEnumerable<MovieShowing> GetMoviesShowing();
}
