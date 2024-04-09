using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JourneyMentor.Domain.Aggregates.FlightAggregate
{
    public class Flights
    {
        [JsonIgnore]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [JsonProperty(PropertyName = "flightDate")]
        public string FlightDate { get; set; }

        [JsonProperty(PropertyName = "flightStatus")]
        public string FlightStatus { get; set; }

        [ForeignKey("DepartureId")]
        [JsonProperty(PropertyName = "departure")]
        public virtual Departure Departure { get; set; }

        [ForeignKey("ArrivalId")]
        [JsonProperty(PropertyName = "arrival")]
        public virtual Arrival Arrival { get; set; }

        [ForeignKey("AirlineId")]
        [JsonProperty(PropertyName = "airline")]
        public virtual Airline Airline { get; set; }

        [ForeignKey("FlightId")]
        [JsonProperty(PropertyName = "flight")]
        public virtual Flight Flight { get; set; }

        [ForeignKey("AircraftId")]
        [JsonProperty(PropertyName = "aircraft")]
        public virtual Aircraft Aircraft { get; set; }

        [ForeignKey("LiveId")]
        [JsonProperty(PropertyName = "live")]
        public virtual Live Live { get; set; }
    }
}
