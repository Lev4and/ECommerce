using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class TrackingInfo
    {
        [JsonProperty("click")]
        public Click Click { get; set; }

        [JsonProperty("videoRewind")]
        public VideoRewind VideoRewind { get; set; }

        [JsonProperty("videoView")]
        public VideoView VideoView { get; set; }

        [JsonProperty("videoViewFinish")]
        public VideoViewFinish VideoViewFinish { get; set; }

        [JsonProperty("view")]
        public View View { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}