namespace JourneyMentor.Api.Contracts.Flights.Responses
{
    public record Flight
    {
        public Guid FlightId { get; set; }
        public string Number { get; set; }
        public string Iata { get; set; }
        public string Icao { get; set; }
        public Codeshared Codeshared { get; set; }
    }
}
