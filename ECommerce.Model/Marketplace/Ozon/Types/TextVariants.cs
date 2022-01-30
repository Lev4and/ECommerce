using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class TextVariants
    {
        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("items")]
        public List<string> Items { get; set; }

        [JsonProperty("testInfo")]
        public TestInfo TestInfo { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}