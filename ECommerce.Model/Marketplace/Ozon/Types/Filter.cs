using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Filter
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hasMoreValues")]
        public bool HasMoreValues { get; set; }

        [JsonProperty("ftype")]
        public string Ftype { get; set; }

        [JsonProperty("shortDesc")]
        public string ShortDesc { get; set; }

        [JsonProperty("urlBase")]
        public string UrlBase { get; set; }

        [JsonProperty("urlSingleValue")]
        public string UrlSingleValue { get; set; }

        [JsonProperty("urlQueryParamName")]
        public string UrlQueryParamName { get; set; }

        [JsonProperty("moreValuesLink")]
        public string MoreValuesLink { get; set; }

        [JsonProperty("moreValuesDeeplink")]
        public string MoreValuesDeeplink { get; set; }

        [JsonProperty("cellTrackingInfo")]
        public CellTrackingInfo CellTrackingInfo { get; set; }

        [JsonProperty("trackingInfo")]
        public TrackingInfo TrackingInfo { get; set; }

        [JsonProperty("values")]
        public List<KeyValue> Values { get; set; }

        [JsonProperty("showInvertedMode")]
        public bool ShowInvertedMode { get; set; }

        [JsonProperty("invertedModeEnabled")]
        public bool InvertedModeEnabled { get; set; }

        [JsonProperty("invertedModeCellTrackingInfo")]
        public InvertedModeCellTrackingInfo InvertedModeCellTrackingInfo { get; set; }

        [JsonProperty("invertedModeTrackingInfo")]
        public InvertedModeTrackingInfo InvertedModeTrackingInfo { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}