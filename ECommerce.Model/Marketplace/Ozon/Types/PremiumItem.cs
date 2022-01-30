using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class PremiumItem
    {
        [JsonProperty("isCategoriesOpenByDefault")]
        public bool IsCategoriesOpenByDefault { get; set; }

        [JsonProperty("title")]
        public List<Title> Title { get; set; }

        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }

        [JsonProperty("switcher")]
        public Switcher Switcher { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}