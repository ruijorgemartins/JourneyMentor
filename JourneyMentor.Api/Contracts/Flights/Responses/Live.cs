namespace JourneyMentor.Api.Contracts.Flights.Responses
{
    public record Live
    {
        public Guid LiveId { get; set; }
        public DateTime Updated { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public int Altitude { get; set; }
        public int Direction { get; set; }
        public int SpeedHorizontal { get; set; }
        public int SpeedVertical { get; set; }
        public bool IsGround { get; set; }
    }
}
