using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class DefaultButton
    {
        [JsonProperty("addPayload")]
        public List<AddPayload> AddPayload { get; set; }

        [JsonProperty("removePayload")]
        public List<RemovePayload> RemovePayload { get; set; }

        [JsonProperty("messageRs")]
        public List<MessageR> MessageRs { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}