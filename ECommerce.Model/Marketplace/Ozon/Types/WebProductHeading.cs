using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class WebProductHeading
    {
        [JsonProperty("cellTrackingInfo")]
        public CellTrackingInfo CellTrackingInfo { get; set; }

        [JsonProperty("sliceTrackingInfo")]
        public string SliceTrackingInfo { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("titleLink")]
        public string TitleLink { get; set; }

        [JsonProperty("subTitle")]
        public string SubTitle { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}