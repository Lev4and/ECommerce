using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class SkuAdvSearchShelf
    {
        [JsonProperty("productContainer")]
        public ProductContainer ProductContainer { get; set; }

        [JsonProperty("widgetOptions")]
        public WidgetOptions WidgetOptions { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}