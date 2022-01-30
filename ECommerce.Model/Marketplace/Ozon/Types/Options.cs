using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Options
    {
        [JsonProperty("openItemLinkInNewTab")]
        public bool OpenItemLinkInNewTab { get; set; }

        [JsonProperty("picSize")]
        public string PicSize { get; set; }

        [JsonProperty("withGaps")]
        public bool WithGaps { get; set; }

        [JsonProperty("itemsAreFaded")]
        public bool ItemsAreFaded { get; set; }

        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("shareURL")]
        public string ShareURL { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}