namespace JourneyMentor.Api.Contracts.Flights.Responses
{
    public record FlightResponse
    {
        public Pagination Pagination { get; set; }
        public List<Flights> Flights { get; set; }
    }
}
