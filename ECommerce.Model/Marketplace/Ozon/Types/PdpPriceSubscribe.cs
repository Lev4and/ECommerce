using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class PdpPriceSubscribe
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("userEmail")]
        public string UserEmail { get; set; }

        [JsonProperty("isLoggedIn")]
        public bool IsLoggedIn { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("isPriceSubscription")]
        public bool IsPriceSubscription { get; set; }

        [JsonProperty("isSubscribed")]
        public bool IsSubscribed { get; set; }

        [JsonProperty("buttonTextSubscribed")]
        public string ButtonTextSubscribed { get; set; }

        [JsonProperty("buttonTextNotSubscribed")]
        public string ButtonTextNotSubscribed { get; set; }

        [JsonProperty("subscribedAndFavoritesMessage")]
        public string SubscribedAndFavoritesMessage { get; set; }

        [JsonProperty("subscribedMessage")]
        public string SubscribedMessage { get; set; }

        [JsonProperty("unsubscribedMessage")]
        public string UnsubscribedMessage { get; set; }

        [JsonProperty("cellTrackingInfo")]
        public CellTrackingInfo CellTrackingInfo { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}