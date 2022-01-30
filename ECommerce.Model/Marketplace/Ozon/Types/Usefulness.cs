using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Usefulness
    {
        [JsonProperty("useful")]
        public int Useful { get; set; }

        [JsonProperty("unuseful")]
        public int Unuseful { get; set; }

        [JsonProperty("userSelection")]
        public string UserSelection { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}