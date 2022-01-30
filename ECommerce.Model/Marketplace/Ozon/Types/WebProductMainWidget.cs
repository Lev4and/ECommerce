using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class WebProductMainWidget
    {
        [JsonProperty("sku")]
        public int Sku { get; set; }

        [JsonProperty("isOutOfStockMode")]
        public bool IsOutOfStockMode { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("cellTrackingInfo")]
        public CellTrackingInfo CellTrackingInfo { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}