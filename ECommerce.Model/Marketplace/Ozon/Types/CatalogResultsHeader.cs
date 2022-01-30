using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class CatalogResultsHeader
    {
        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("totalFound")]
        public string TotalFound { get; set; }

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