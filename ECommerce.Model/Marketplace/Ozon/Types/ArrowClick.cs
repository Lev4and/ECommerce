using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class ArrowClick
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("elementType")]
        public string ElementType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}