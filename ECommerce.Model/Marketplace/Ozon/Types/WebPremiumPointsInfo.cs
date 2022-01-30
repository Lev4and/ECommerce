using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class WebPremiumPointsInfo
    {
        [JsonProperty("premiumItem")]
        public PremiumItem PremiumItem { get; set; }

        [JsonProperty("nonPremiumItem")]
        public object NonPremiumItem { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}