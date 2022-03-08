using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.ResourceWebApplication.Models
{
    public class CatalogRequestModel
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("sorting")]
        public string Sorting { get; set; }

        [JsonProperty("filters")]
        public string Filters { get; set; }

        [Required]
        [JsonProperty("categoryUrl")]
        public string CategoryUrl { get; set; }
    }
}
