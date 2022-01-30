using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class WebListPhotos
    {
        [JsonProperty("mediaContent")]
        public List<MediaContent> MediaContent { get; set; }

        [JsonProperty("moreMedia")]
        public MoreMedia MoreMedia { get; set; }

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