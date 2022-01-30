using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class CartAnalyticsInfo
    {
        [JsonProperty("totalCartPrice")]
        public int TotalCartPrice { get; set; }

        [JsonProperty("tabName")]
        public string TabName { get; set; }

        [JsonProperty("totalSelectedPrice")]
        public int TotalSelectedPrice { get; set; }

        [JsonProperty("totalCartQuantity")]
        public int TotalCartQuantity { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}