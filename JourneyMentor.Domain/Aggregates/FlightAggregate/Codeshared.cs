using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JourneyMentor.Domain.Aggregates.FlightAggregate
{
    public class Codeshared
    {
        [JsonIgnore]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CodesharedId { get; set; }

        [JsonProperty(PropertyName = "airline_name")]
        public string AirlineName { get; set; }

        [JsonProperty(PropertyName = "airline_iata")]
        public string AirlineIata { get; set; }

        [JsonProperty(PropertyName = "airline_icao")]
        public string AirlineIcao { get; set; }

        [JsonProperty(PropertyName = "flight_number")]
        public string FlightNumber { get; set; }

        [JsonProperty(PropertyName = "flight_iata")]
        public string FlightIata { get; set; }

        [JsonProperty(PropertyName = "flight_icao")]
        public string FlightIcao { get; set; }
    }
}
