using ECommerce.Model.Marketplace.Ozon.Types;
using Newtonsoft.Json;

namespace ECommerce.HttpClients.Ozon.ResponseModels
{
    public class Reviews
    {
        [JsonProperty("state")]
        public ReviewsState State { get; set; }

        [JsonProperty("trackingPayloads")]
        public Dictionary<string, string> TrackingPayloads { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
