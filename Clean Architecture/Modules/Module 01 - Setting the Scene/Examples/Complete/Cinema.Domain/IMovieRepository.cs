namespace Cinema.Domain;

public interface IMovieRepository
{
    IEnumerable<Movie> GetAll();
    IEnumerable<Movie> GetAllShowing();
}
