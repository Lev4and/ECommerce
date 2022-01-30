using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class TextAtomWithIcon
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textStyle")]
        public string TextStyle { get; set; }

        [JsonProperty("textColor")]
        public string TextColor { get; set; }

        [JsonProperty("maxLines")]
        public int MaxLines { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("iconTintColor")]
        public string IconTintColor { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}