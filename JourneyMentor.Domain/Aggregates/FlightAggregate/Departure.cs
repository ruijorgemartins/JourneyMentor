using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JourneyMentor.Domain.Aggregates.FlightAggregate
{
    public class Departure
    {
        [JsonIgnore]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DepartureId { get; set; }

        [JsonProperty(PropertyName = "airport")]
        public string Airport { get; set; }

        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }

        [JsonProperty(PropertyName = "iata")]
        public string Iata { get; set; }

        [JsonProperty(PropertyName = "icao")]
        public string Icao { get; set; }

        [JsonProperty(PropertyName = "terminal")]
        public string Terminal { get; set; }

        [JsonProperty(PropertyName = "gate")]
        public string Gate { get; set; }

        [JsonProperty(PropertyName = "delay")]
        public int? Delay { get; set; }

        [JsonProperty(PropertyName = "scheduled")]
        public DateTime Scheduled { get; set; }

        [JsonProperty(PropertyName = "estimated")]
        public DateTime Estimated { get; set; }

        [JsonProperty(PropertyName = "actual")]
        public DateTime Actual { get; set; }

        [JsonProperty(PropertyName = "estimated_runway")]
        public DateTime EstimatedRunway { get; set; }

        [JsonProperty(PropertyName = "actual_runway")]
        public DateTime ActualRunway { get; set; }
    }
}
