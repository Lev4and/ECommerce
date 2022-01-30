using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class SmallIconButton
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("action")]
        public Action Action { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("trackingInfo")]
        public TrackingInfo TrackingInfo { get; set; }

        [JsonProperty("testInfo")]
        public TestInfo TestInfo { get; set; }

        [JsonProperty("tintColor")]
        public string TintColor { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}