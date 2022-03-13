using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.ResourceWebApplication.Models
{
    public class AllFiltersRequestModel
    {
        [JsonProperty("filters")]
        public string Filters { get; set; }

        [Required]
        [JsonProperty("categoryUrl")]
        public string CategoryUrl { get; set; }
    }
}
