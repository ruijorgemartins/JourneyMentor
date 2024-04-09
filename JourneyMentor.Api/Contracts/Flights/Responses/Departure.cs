﻿namespace JourneyMentor.Api.Contracts.Flights.Responses
{
    public record Departure
    {
        public Guid DepartureId { get; set; }
        public string Airport { get; set; }
        public string Timezone { get; set; }
        public string Iata { get; set; }
        public string Icao { get; set; }
        public string Terminal { get; set; }
        public string Gate { get; set; }
        public int? Delay { get; set; }
        public DateTime Scheduled { get; set; }
        public DateTime Estimated { get; set; }
        public DateTime Actual { get; set; }
        public DateTime EstimatedRunway { get; set; }
        public DateTime ActualRunway { get; set; }
    }
}
