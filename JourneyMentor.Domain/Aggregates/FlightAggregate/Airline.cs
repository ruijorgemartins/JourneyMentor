using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JourneyMentor.Domain.Aggregates.FlightAggregate
{
    public class Airline
    {
        [JsonIgnore]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AirlineId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "iata")]
        public string Iata { get; set; }

        [JsonProperty(PropertyName = "icao")]
        public string Icao { get; set; }
    }
}
