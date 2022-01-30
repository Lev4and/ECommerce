using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Badge
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("tintColor")]
        public string TintColor { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("testInfo")]
        public TestInfo TestInfo { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("iconPosition")]
        public string IconPosition { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}