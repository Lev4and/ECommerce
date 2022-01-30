using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class WebAddToCart
    {
        [JsonProperty("cellTrackingInfo")]
        public CellTrackingInfo CellTrackingInfo { get; set; }

        [JsonProperty("sliceTrackingInfo")]
        public string SliceTrackingInfo { get; set; }

        [JsonProperty("sku")]
        public int Sku { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("actions")]
        public List<object> Actions { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("subscriptionUrl")]
        public string SubscriptionUrl { get; set; }

        [JsonProperty("cartUrl")]
        public string CartUrl { get; set; }

        [JsonProperty("iis")]
        public int Iis { get; set; }

        [JsonProperty("defaultButton")]
        public DefaultButton DefaultButton { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}