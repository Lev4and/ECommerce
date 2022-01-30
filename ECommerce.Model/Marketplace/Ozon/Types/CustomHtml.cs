using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class CustomHtml
    {
        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("disableJquery")]
        public bool DisableJquery { get; set; }

        [JsonProperty("css")]
        public string Css { get; set; }

        [JsonProperty("js")]
        public string Js { get; set; }

        [JsonProperty("resources")]
        public List<object> Resources { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }

}