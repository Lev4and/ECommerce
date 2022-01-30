using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class LayoutTrackingInfo
    {
        [JsonProperty("layoutId")]
        public int LayoutId { get; set; }

        [JsonProperty("layoutVersion")]
        public int LayoutVersion { get; set; }

        [JsonProperty("pageType")]
        public string PageType { get; set; }

        [JsonProperty("ruleId")]
        public int RuleId { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        [JsonProperty("hierarchy")]
        public string Hierarchy { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("templateType")]
        public string TemplateType { get; set; }

        [JsonProperty("brandId")]
        public int BrandId { get; set; }

        [JsonProperty("brandName")]
        public string BrandName { get; set; }

        [JsonProperty("currentPageUrl")]
        public string CurrentPageUrl { get; set; }

        [JsonProperty("sku")]
        public int Sku { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}