namespace JourneyMentor.Api.Contracts.Flights.Responses
{
    public record Pagination
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
        public int Count { get; set; }
        public int Total { get; set; }
    }
}
