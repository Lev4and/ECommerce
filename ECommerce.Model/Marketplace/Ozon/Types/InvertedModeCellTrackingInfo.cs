using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class InvertedModeCellTrackingInfo
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("elementType")]
        public string ElementType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("filterValue")]
        public string FilterValue { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}