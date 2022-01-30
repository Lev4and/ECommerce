using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Button2
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("addToCartButton")]
        public AddToCartButton AddToCartButton { get; set; }

        [JsonProperty("addToCartButtonWithQuantity")]
        public AddToCartButtonWithQuantity AddToCartButtonWithQuantity { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}