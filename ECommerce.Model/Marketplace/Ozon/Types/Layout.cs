using ECommerce.Model.JsonConverters;
using Newtonsoft.Json;

namespace ECommerce.Model.Marketplace.Ozon.Types
{
    public class Layout
    {
        [JsonProperty("component")]
        public string Component { get; set; }

        [JsonProperty("params")]
        [JsonConverter(typeof(ToObjectJsonConverter<Params>))]
        public Params Params { get; set; }

        [JsonProperty("stateId")]
        public string StateId { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("vertical")]
        public string Vertical { get; set; }

        [JsonProperty("widgetTrackingInfo")]
        [JsonConverter(typeof(ToObjectJsonConverter<WidgetTrackingInfo>))]
        public WidgetTrackingInfo WidgetTrackingInfo { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("widgetToken")]
        public string WidgetToken { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("placeholders")]
        public List<Placeholder> Placeholders { get; set; }

        [JsonProperty("asyncType")]
        public string AsyncType { get; set; }

        [JsonProperty("asyncData")]
        public string AsyncData { get; set; }

        [JsonProperty("trackingOn")]
        public bool? TrackingOn { get; set; }

        [JsonProperty("timeSpent")]
        public int? TimeSpent { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}