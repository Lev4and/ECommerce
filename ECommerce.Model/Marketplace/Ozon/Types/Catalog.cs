using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Catalog
    {
        [JsonProperty("activeSort")]
        public string ActiveSort { get; set; }

        [JsonProperty("brand")]
        public object Brand { get; set; }

        [JsonProperty("breadCrumbs")]
        public List<BreadCrumb> BreadCrumbs { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("categoryPredicted")]
        public bool CategoryPredicted { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("correctedText")]
        public string CorrectedText { get; set; }

        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        [JsonProperty("currentText")]
        public string CurrentText { get; set; }

        [JsonProperty("currentUrl")]
        public string CurrentUrl { get; set; }

        [JsonProperty("searchContext")]
        public SearchContext SearchContext { get; set; }

        [JsonProperty("totalFound")]
        public int TotalFound { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}