using Cinema.DataAccess.Sql;
using Cinema.Domain;

MovieService service = new();
IEnumerable<Movie> movies = service.GetMoviesShowing();

foreach (Movie movie in movies)
{
    string ticketPriceDisplay = movie.TicketPrice.HasValue
        ? $"- {movie.TicketPrice?.ToString("C")}"
        : string.Empty;
    
    Console.WriteLine($"{movie.Name} [{movie.Year}] {ticketPriceDisplay}");
}