namespace Cinema.Domain;

public class Movie
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required short Year { get; set; }
    public required string Plot { get; set; }
    public double? ImdbRating { get; set; }
    public decimal? TicketPrice { get; set; }
    public required bool IsShowing { get; set; }
    public DateTime? LastUpdated { get; set; }
}
