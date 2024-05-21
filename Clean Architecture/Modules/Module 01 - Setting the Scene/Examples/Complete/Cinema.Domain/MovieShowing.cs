namespace Cinema.Domain;

public record MovieShowing
{
    public required string Name { get; init; }
    public required short Year { get; init; }
    public decimal? TicketPrice { get; init; }
}
