using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class ItemListElement
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}