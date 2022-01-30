using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Tooltip
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }

        [JsonProperty("buttons")]
        public List<Button> Buttons { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}