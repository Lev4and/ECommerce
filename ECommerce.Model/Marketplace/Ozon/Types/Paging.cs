using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Paging
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("rgPage")]
        public int RgPage { get; set; }

        [JsonProperty("perPage")]
        public int PerPage { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}