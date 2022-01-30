using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Footer
    {
        [JsonProperty("footerColumns")]
        public List<FooterColumn> FooterColumns { get; set; }

        [JsonProperty("footerLinks")]
        public List<FooterLink> FooterLinks { get; set; }

        [JsonProperty("copyright")]
        public Copyright Copyright { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("logo")]
        public Logo Logo { get; set; }

        [JsonProperty("accessibilityButton")]
        public AccessibilityButton AccessibilityButton { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}