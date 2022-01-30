using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class SearchContext
    {
        [JsonProperty("context_title")]
        public string ContextTitle { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("suggestion_enabled")]
        public bool SuggestionEnabled { get; set; }

        [JsonProperty("tapTags_enabled")]
        public bool TapTagsEnabled { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("is_global")]
        public bool IsGlobal { get; set; }

        [JsonProperty("force_context")]
        public bool ForceContext { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}