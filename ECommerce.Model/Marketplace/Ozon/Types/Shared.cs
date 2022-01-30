using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Shared
    {
        [JsonProperty("cartAnalyticsInfo")]
        public CartAnalyticsInfo CartAnalyticsInfo { get; set; }

        [JsonProperty("cartItems")]
        public object CartItems { get; set; }

        [JsonProperty("catalog")]
        public Catalog Catalog { get; set; }

        [JsonProperty("cellTrackingInfo")]
        public CellTrackingInfo CellTrackingInfo { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("itemsTrackingInfo")]
        public List<object> ItemsTrackingInfo { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}