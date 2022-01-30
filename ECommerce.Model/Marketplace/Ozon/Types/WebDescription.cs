using Newtonsoft.Json;

namespace ECommerce.Model.Marketplace.Ozon.Types
{
    public class WebDescription
    {
        [JsonProperty("richAnnotation")]
        public string RichAnnotation { get; set; }

        [JsonProperty("richAnnotationType")]
        public string RichAnnotationType { get; set; }

        [JsonProperty("cellTrackingInfo")]
        public CellTrackingInfo CellTrackingInfo { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}