using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JourneyMentor.Domain.Aggregates.FlightAggregate
{
    public class Flight
    {
        [JsonIgnore]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid FlightId { get; set; }

        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        [JsonProperty(PropertyName = "iata")]
        public string Iata { get; set; }

        [JsonProperty(PropertyName = "icao")]
        public string Icao { get; set; }

        [ForeignKey("CodesharedId")]
        [JsonProperty(PropertyName = "codeshared")]
        public virtual Codeshared Codeshared { get; set; }
    }
}
