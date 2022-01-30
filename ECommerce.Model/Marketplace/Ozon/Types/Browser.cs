using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Browser
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("isDesktop")]
        public bool IsDesktop { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("browser")]
        public string Name { get; set; }

        [JsonProperty("prevLocation")]
        public string PrevLocation { get; set; }

        [JsonProperty("useSpa")]
        public bool UseSpa { get; set; }

        [JsonProperty("useSW")]
        public bool UseSW { get; set; }

        [JsonProperty("trackResources")]
        public bool TrackResources { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}