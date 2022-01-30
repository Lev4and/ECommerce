using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Client
    {
        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("jsonVersion")]
        public string JsonVersion { get; set; }

        [JsonProperty("trackingVersion")]
        public string TrackingVersion { get; set; }

        [JsonProperty("tagManagerVersion")]
        public string TagManagerVersion { get; set; }

        [JsonProperty("clientMetricsVersion")]
        public string ClientMetricsVersion { get; set; }

        [JsonProperty("cdtVersion")]
        public string CdtVersion { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}