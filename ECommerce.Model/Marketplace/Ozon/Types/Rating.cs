using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Rating
    {
        [JsonProperty("rating")]
        public double Value { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("action")]
        public Action Action { get; set; }

        [JsonProperty("trackingInfo")]
        public TrackingInfo TrackingInfo { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}