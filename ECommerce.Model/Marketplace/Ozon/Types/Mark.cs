using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Mark
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("colorFont")]
        public string ColorFont { get; set; }

        [JsonProperty("colorBackground")]
        public string ColorBackground { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}