namespace Cinema.Domain;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _repository;

    public MovieService(IMovieRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<MovieShowing> GetMoviesShowing()
    {
        var moviesShowing = _repository
            .GetAllShowing()
            .Select(movie => new MovieShowing
            {
                Name = movie.Name,
                Year = movie.Year,
                TicketPrice = movie.TicketPrice
            })
            ;

        return moviesShowing;
    }
}
