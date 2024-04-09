using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JourneyMentor.Domain.Aggregates.FlightAggregate
{
    public class Live
    {
        [JsonIgnore]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LiveId { get; set; }

        [JsonProperty(PropertyName = "updated")]
        public DateTime Updated { get; set; }

        [JsonProperty(PropertyName = "latitude")]
        public int Latitude { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public int Longitude { get; set; }

        [JsonProperty(PropertyName = "altitude")]
        public int Altitude { get; set; }

        [JsonProperty(PropertyName = "direction")]
        public int Direction { get; set; }

        [JsonProperty(PropertyName = "speed_horizontal")]
        public int SpeedHorizontal { get; set; }

        [JsonProperty(PropertyName = "speed_vertical")]
        public int SpeedVertical { get; set; }

        [JsonProperty(PropertyName = "is_ground")]
        public bool IsGround { get; set; }
    }
}
