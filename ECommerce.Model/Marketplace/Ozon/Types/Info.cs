using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Info
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("imageUrls")]
        public ImageUrls ImageUrls { get; set; }

        [JsonProperty("urlValue")]
        public string UrlValue { get; set; }

        [JsonProperty("isAdult")]
        public bool IsAdult { get; set; }

        [JsonProperty("overrideUrl")]
        public string OverrideUrl { get; set; }

        [JsonProperty("overrideDeeplink")]
        public string OverrideDeeplink { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}