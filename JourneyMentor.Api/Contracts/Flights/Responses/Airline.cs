namespace JourneyMentor.Api.Contracts.Flights.Responses
{
    public record Airline
    {
        public Guid AirlineId { get; set; }
        public string Name { get; set; }
        public string Iata { get; set; }
        public string Icao { get; set; }
    }
}
