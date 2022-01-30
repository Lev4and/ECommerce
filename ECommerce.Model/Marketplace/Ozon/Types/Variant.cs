using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Variant
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}