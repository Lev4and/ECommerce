using ECommerce.Model.JsonConverters;
using Newtonsoft.Json;

namespace ECommerce.Model.Marketplace.Ozon.Types
{
    public class Script
    {
        [JsonProperty("innerHTML")]
        [JsonConverter(typeof(ToObjectJsonConverter<InnerHTML>))]
        public InnerHTML InnerHTML { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}