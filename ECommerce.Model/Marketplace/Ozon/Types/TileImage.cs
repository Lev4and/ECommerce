using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class TileImage
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("images")]
        public List<string> Images { get; set; }

        [JsonProperty("imageRatio")]
        public string ImageRatio { get; set; }

        [JsonProperty("imageBadges")]
        public List<ImageBadge> ImageBadges { get; set; }

        [JsonProperty("overlayTitle")]
        public string OverlayTitle { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}