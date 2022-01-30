using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class SearchResultsFiltersActive
    {
        [JsonProperty("uriBase")]
        public string UriBase { get; set; }

        [JsonProperty("disableAllText")]
        public string DisableAllText { get; set; }

        [JsonProperty("activeFilters")]
        public List<object> ActiveFilters { get; set; }

        [JsonProperty("cellTrackingInfo")]
        public CellTrackingInfo CellTrackingInfo { get; set; }

        [JsonProperty("trackingInfo")]
        public TrackingInfo TrackingInfo { get; set; }

        [JsonProperty("isAtomic")]
        public bool IsAtomic { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}