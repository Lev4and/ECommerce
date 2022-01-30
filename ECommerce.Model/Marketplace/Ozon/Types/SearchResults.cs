using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class SearchResults
    {
        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        [JsonProperty("templates")]
        public object Templates { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("cols")]
        public int Cols { get; set; }

        [JsonProperty("tileLayout")]
        public string TileLayout { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}