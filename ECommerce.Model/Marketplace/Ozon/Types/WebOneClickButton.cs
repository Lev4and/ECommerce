using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class WebOneClickButton
    {
        [JsonProperty("payload")]
        public Payload Payload { get; set; }

        [JsonProperty("sku")]
        public int Sku { get; set; }

        [JsonProperty("redirectLink")]
        public string RedirectLink { get; set; }

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