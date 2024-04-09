using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JourneyMentor.Domain.Aggregates.AirportAggregate
{
    public class Airport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "gmt")]
        public string Gmt { get; set; }

        [JsonProperty(PropertyName = "airportId")]
        public string AirportId { get; set; }

        [JsonProperty(PropertyName = "iataCode")]
        public string IataCode { get; set; }

        [JsonProperty(PropertyName = "cityIataCode")]
        public string CityIataCode { get; set; }

        [JsonProperty(PropertyName = "icaoCode")]
        public string IcaoCode { get; set; }

        [JsonProperty(PropertyName = "countryIso2")]
        public string CountryIso2 { get; set; }

        [JsonProperty(PropertyName = "geonameId")]
        public string GeonameId { get; set; }

        [JsonProperty(PropertyName = "latitude")]
        public string Latitude { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public string Longitude { get; set; }

        [JsonProperty(PropertyName = "airportName")]
        public string AirportName { get; set; }

        [JsonProperty(PropertyName = "countryName")]
        public string CountryName { get; set; }

        [JsonProperty(PropertyName = "phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }
    }
}
