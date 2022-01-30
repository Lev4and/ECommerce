using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class WebPrice
    {
        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("originalPrice")]
        public string OriginalPrice { get; set; }

        [JsonProperty("showOriginalPrice")]
        public bool ShowOriginalPrice { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("payment")]
        public string Payment { get; set; }

        [JsonProperty("paymentTerm")]
        public string PaymentTerm { get; set; }

        [JsonProperty("hintLink")]
        public string HintLink { get; set; }

        [JsonProperty("hintText")]
        public string HintText { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}