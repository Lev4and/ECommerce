using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Current
    {
        [JsonProperty("areaId")]
        public int AreaId { get; set; }

        [JsonProperty("areaType")]
        public int AreaType { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("countryId")]
        public int CountryId { get; set; }

        [JsonProperty("fias")]
        public string Fias { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("timeZoneUtcname")]
        public string TimeZoneUtcname { get; set; }

        [JsonProperty("geoCoordinate")]
        public GeoCoordinate GeoCoordinate { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}