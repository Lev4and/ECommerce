using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class SearchResultsSort
    {
        [JsonProperty("sortings")]
        public List<Sorting> Sortings { get; set; }

        [JsonProperty("selectedFiltersCount")]
        public int SelectedFiltersCount { get; set; }

        [JsonProperty("selectedValuesCount")]
        public int SelectedValuesCount { get; set; }

        [JsonProperty("urlBase")]
        public string UrlBase { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}