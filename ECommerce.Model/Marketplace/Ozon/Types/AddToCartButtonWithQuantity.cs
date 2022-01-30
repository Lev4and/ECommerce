using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class AddToCartButtonWithQuantity
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("maxItems")]
        public int MaxItems { get; set; }

        [JsonProperty("currentItems")]
        public int CurrentItems { get; set; }

        [JsonProperty("action")]
        public Action Action { get; set; }

        [JsonProperty("trackingInfo")]
        public TrackingInfo TrackingInfo { get; set; }

        [JsonProperty("testInfo")]
        public TestInfo TestInfo { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}