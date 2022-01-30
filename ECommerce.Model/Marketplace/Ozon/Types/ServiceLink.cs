using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class ServiceLink
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("isSpecial")]
        public bool IsSpecial { get; set; }

        [JsonProperty("cellTrackingInfo")]
        public CellTrackingInfo CellTrackingInfo { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonProperty("sliceTrackingInfo")]
        public SliceTrackingInfo SliceTrackingInfo { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}