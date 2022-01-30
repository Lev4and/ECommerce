using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class View
    {
        [JsonProperty("actionType")]
        public string ActionType { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("sliceKey")]
        public string SliceKey { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sku")]
        public int Sku { get; set; }

        [JsonProperty("finalPrice")]
        public int FinalPrice { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("advId")]
        public string AdvId { get; set; }

        [JsonProperty("nested")]
        public List<object> Nested { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}