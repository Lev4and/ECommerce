using ECommerce.Model.JsonConverters;
using ECommerce.Model.Marketplace.Ozon.Types;
using Newtonsoft.Json;

namespace ECommerce.HttpClients.Ozon.ResponseModels
{
    public class AllFilters
    {
        [JsonProperty("layout")]
        public List<Layout> Layout { get; set; }

        [JsonProperty("widgetStates")]
        public WidgetStates WidgetStates { get; set; }

        [JsonProperty("browser")]
        public Browser Browser { get; set; }

        [JsonProperty("client")]
        public Client Client { get; set; }

        [JsonProperty("layoutTrackingInfo")]
        [JsonConverter(typeof(ToObjectJsonConverter<LayoutTrackingInfo>))]
        public LayoutTrackingInfo LayoutTrackingInfo { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("seo")]
        public Seo Seo { get; set; }

        [JsonProperty("shared")]
        [JsonConverter(typeof(ToObjectJsonConverter<Shared>))]
        public Shared Shared { get; set; }

        [JsonProperty("pageInfo")]
        public PageInfo PageInfo { get; set; }

        [JsonProperty("trackingPayloads")]
        public Dictionary<string, string> TrackingPayloads { get; set; }

        [JsonProperty("pageToken")]
        public string PageToken { get; set; }

        [JsonProperty("userToken")]
        public string UserToken { get; set; }

        [JsonProperty("experimentsConfig")]
        public ExperimentsConfig ExperimentsConfig { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
