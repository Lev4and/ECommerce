using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class SearchResultsFilters
    {
        [JsonProperty("filters")]
        public List<Filter> Filters { get; set; }

        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }

        [JsonProperty("finalCategories")]
        public List<object> FinalCategories { get; set; }

        [JsonProperty("urlBaseCategory")]
        public string UrlBaseCategory { get; set; }

        [JsonProperty("totalFound")]
        public string TotalFound { get; set; }

        [JsonProperty("urlBase")]
        public string UrlBase { get; set; }

        [JsonProperty("urlCategoryQueryParam")]
        public string UrlCategoryQueryParam { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("categoriesToggleButton")]
        public bool CategoriesToggleButton { get; set; }

        [JsonProperty("urlBack")]
        public string UrlBack { get; set; }

        [JsonProperty("categoriesPreview")]
        public List<object> CategoriesPreview { get; set; }

        [JsonProperty("showAllCategoriesText")]
        public string ShowAllCategoriesText { get; set; }

        [JsonProperty("allFiltersUrl")]
        public string AllFiltersUrl { get; set; }

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