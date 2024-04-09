using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JourneyMentor.Domain.Aggregates.FlightAggregate
{
    public class Aircraft
    {
        [JsonIgnore]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AircraftId { get; set; }

        [JsonProperty(PropertyName = "registration")]
        public string Registration { get; set; }

        [JsonProperty(PropertyName = "iata")]
        public string Iata { get; set; }

        [JsonProperty(PropertyName = "icao")]
        public string Icao { get; set; }

        [JsonProperty(PropertyName = "icao24")]
        public string Icao24 { get; set; }
    }
}
