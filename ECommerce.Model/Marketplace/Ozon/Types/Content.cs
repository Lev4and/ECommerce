using Newtonsoft.Json;

namespace ECommerce.Model.Marketplace.Ozon.Types
{
    public class Content
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("elementType")]
        public string ElementType { get; set; }

        [JsonProperty("sku")]
        public int Sku { get; set; }

        [JsonProperty("advId")]
        public string AdvId { get; set; }

        [JsonProperty("headRs")]
        public List<HeadR> HeadRs { get; set; }

        [JsonProperty("hintRs")]
        public List<HintR> HintRs { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}