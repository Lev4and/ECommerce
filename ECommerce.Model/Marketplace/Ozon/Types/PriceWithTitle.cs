using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class PriceWithTitle
    {
        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("priceColor")]
        public string PriceColor { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("titleColor")]
        public string TitleColor { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}