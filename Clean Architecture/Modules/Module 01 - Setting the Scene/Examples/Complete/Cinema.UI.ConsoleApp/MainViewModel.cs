using Cinema.Domain;

public class MainViewModel
{
    public IEnumerable<MovieViewModel> Movies { get; }

    public MainViewModel(IEnumerable<MovieShowing> movies)
    {
        Movies = movies
            .Select(movie => new MovieViewModel(movie))
            ;
    }
}
