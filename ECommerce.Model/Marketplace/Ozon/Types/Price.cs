using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Price
    {
        [JsonProperty("price")]
        public string Value { get; set; }

        [JsonProperty("priceColor")]
        public string PriceColor { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("originalPrice")]
        public string OriginalPrice { get; set; }

        [JsonProperty("originalPriceColor")]
        public string OriginalPriceColor { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("imageTintColor")]
        public string ImageTintColor { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}