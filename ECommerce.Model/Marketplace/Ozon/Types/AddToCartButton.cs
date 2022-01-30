using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class AddToCartButton
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("activeText")]
        public string ActiveText { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("action")]
        public Action Action { get; set; }

        [JsonProperty("trackingInfo")]
        public TrackingInfo TrackingInfo { get; set; }

        [JsonProperty("testInfo")]
        public TestInfo TestInfo { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}