using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Offer
    {
        [JsonProperty("isSelected")]
        public bool IsSelected { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("originalPrice")]
        public string OriginalPrice { get; set; }

        [JsonProperty("relativeLink")]
        public string RelativeLink { get; set; }

        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("subMessage")]
        public string SubMessage { get; set; }

        [JsonProperty("offerName")]
        public string OfferName { get; set; }

        [JsonProperty("offerType")]
        public string OfferType { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("priceCurrency")]
        public string PriceCurrency { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}