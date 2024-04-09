namespace JourneyMentor.Api.Contracts.Flights.Responses
{
    public record Aircraft
    {
        public Guid AircraftId { get; set; }
        public string Registration { get; set; }
        public string Iata { get; set; }
        public string Icao { get; set; }
        public string Icao24 { get; set; }
    }
}
