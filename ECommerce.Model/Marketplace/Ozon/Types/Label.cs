using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Label
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("hint")]
        public string Hint { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("fontColor")]
        public string FontColor { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("keyValue")]
        public string KeyValue { get; set; }

        [JsonProperty("iconKey")]
        public string IconKey { get; set; }

        [JsonProperty("names")]
        public List<string> Names { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}