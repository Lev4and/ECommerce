using ECommerce.Model.Marketplace.Ozon.Types;
using Newtonsoft.Json;

namespace ECommerce.HttpClients.Ozon.ResponseModels
{
    public class Category
    {
        [JsonProperty("promo")]
        public List<Promo> Promo { get; set; }

        [JsonProperty("promoPics")]
        public List<PromoPic> PromoPics { get; set; }

        [JsonProperty("categories")]
        public List<ChildCategory> Categories { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
