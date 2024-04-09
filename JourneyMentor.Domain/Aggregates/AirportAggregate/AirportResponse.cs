using Newtonsoft.Json;

namespace JourneyMentor.Domain.Aggregates.AirportAggregate
{
    public class AirportResponse
    {
        [JsonProperty(PropertyName = "pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty(PropertyName = "data")]
        public List<Airport> Airports { get; set; }
    }
}
