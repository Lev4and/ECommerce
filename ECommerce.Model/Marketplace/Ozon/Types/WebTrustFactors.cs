using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class WebTrustFactors
    {
        [JsonProperty("sku")]
        public int Sku { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("trustFactors")]
        public List<TrustFactor> TrustFactors { get; set; }

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