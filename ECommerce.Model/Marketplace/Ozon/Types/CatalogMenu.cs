using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class CatalogMenu
    {
        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }

        [JsonProperty("marketing")]
        public List<Marketing> Marketing { get; set; }

        [JsonProperty("actionHost")]
        public string ActionHost { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}