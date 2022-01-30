using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class PageInfo
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("layoutId")]
        public int LayoutId { get; set; }

        [JsonProperty("layoutVersion")]
        public int LayoutVersion { get; set; }

        [JsonProperty("pageType")]
        public string PageType { get; set; }

        [JsonProperty("ruleId")]
        public int RuleId { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}