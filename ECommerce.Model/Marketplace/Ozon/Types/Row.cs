using Newtonsoft.Json;

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Row
    {
        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}