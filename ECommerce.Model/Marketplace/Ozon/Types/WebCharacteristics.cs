using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class WebCharacteristics
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("characteristics")]
        public List<Characteristic> Characteristics { get; set; }

        [JsonProperty("productTitle")]
        public string ProductTitle { get; set; }

        [JsonProperty("paramsLink")]
        public string ParamsLink { get; set; }

        [JsonProperty("paramsLinkText")]
        public string ParamsLinkText { get; set; }

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