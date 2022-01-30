using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class ProfileMenuAnonymous
    {
        [JsonProperty("iconTitle")]
        public string IconTitle { get; set; }

        [JsonProperty("tooltip")]
        public Tooltip Tooltip { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}