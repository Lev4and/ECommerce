using Newtonsoft.Json; 
using System.Collections.Generic;

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Seo
    {
        [JsonProperty("h1")]
        public string H1 { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public List<Link> Link { get; set; }

        [JsonProperty("meta")]
        public List<Meta> Meta { get; set; }

        [JsonProperty("script")]
        public List<Script> Script { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}