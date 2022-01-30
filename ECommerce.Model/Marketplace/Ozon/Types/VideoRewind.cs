using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class VideoRewind
    {
        [JsonProperty("actionType")]
        public string ActionType { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("nested")]
        public List<object> Nested { get; set; }

        [JsonProperty("sliceKey")]
        public string SliceKey { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}