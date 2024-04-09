using Newtonsoft.Json;

namespace JourneyMentor.Domain.Aggregates.FlightAggregate
{
    public class FlightResponse
    {
        public FlightResponse(Pagination pagination, List<Flights> flights)
        {
            Pagination = pagination;
            Flights = flights;
        }

        [JsonProperty(PropertyName = "pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty(PropertyName = "data")]
        public List<Flights> Flights { get; set; }
    }
}
