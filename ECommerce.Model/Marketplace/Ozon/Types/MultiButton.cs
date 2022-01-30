using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class MultiButton
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("ozonButton")]
        public OzonButton OzonButton { get; set; }

        [JsonProperty("ozonSubtitle")]
        public OzonSubtitle OzonSubtitle { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}