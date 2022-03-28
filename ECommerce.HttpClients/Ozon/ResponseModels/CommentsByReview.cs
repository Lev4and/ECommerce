using ECommerce.Model.Marketplace.Ozon.Types;
using Newtonsoft.Json;

namespace ECommerce.HttpClients.Ozon.ResponseModels
{
    public class CommentsByReview
    {
        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonProperty("cellTrackingInfo")]
        public CellTrackingInfo CellTrackingInfo { get; set; }

        [JsonProperty("comments")]
        public List<List> Comments { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
