using Newtonsoft.Json;

namespace ECommerce.ResourceWebApplication.Models
{
    public class SearchSuggestionsRequestModel
    {
        [JsonProperty("categoryUrl")]
        public string CategoryUrl { get; set; }

        [JsonProperty("searchString")]
        public string SearchString { get; set; }
    }
}
