using Cinema.Domain;

namespace Cinema.DataAccess.Sql;

public class SqlMovieRepository : IMovieRepository
{
    private readonly MovieContext _context;

    public SqlMovieRepository(MovieContext context)
    {
        _context = context;
    }

    public IEnumerable<Movie> GetAll() => [.. _context.Movies];

    public IEnumerable<Movie> GetAllShowing() => [.. _context.Movies.Where(movie => movie.IsShowing)];
}
