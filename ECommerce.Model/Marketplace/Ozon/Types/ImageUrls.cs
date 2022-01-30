using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class ImageUrls
    {
        [JsonProperty("catalog_logo")]
        public string CatalogLogo { get; set; }

        [JsonProperty("mobileIcon")]
        public string MobileIcon { get; set; }

        [JsonProperty("svgIcon")]
        public string SvgIcon { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}