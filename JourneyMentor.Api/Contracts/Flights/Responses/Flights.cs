namespace JourneyMentor.Api.Contracts.Flights.Responses
{
    public record Flights
    {
        public Guid Id { get; set; }
        public string FlightDate { get; set; }
        public string FlightStatus { get; set; }
        public Departure Departure { get; set; }
        public Arrival Arrival { get; set; }
        public Airline Airline { get; set; }
        public Flight Flight { get; set; }
        public Aircraft Aircraft { get; set; }
        public Live Live { get; set; }
    }
}
