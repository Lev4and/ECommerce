using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class ProductContainer
    {
        [JsonProperty("products")]
        public List<Product> Products { get; set; }

        [JsonProperty("options")]
        public Options Options { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}