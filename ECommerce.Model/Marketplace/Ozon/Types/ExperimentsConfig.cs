using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class ExperimentsConfig
    {
        [JsonProperty("allyMode")]
        public bool AllyMode { get; set; }

        [JsonProperty("clientMetrics")]
        public bool ClientMetrics { get; set; }

        [JsonProperty("deferInShelves")]
        public bool DeferInShelves { get; set; }

        [JsonProperty("disableProductClickEvent")]
        public bool DisableProductClickEvent { get; set; }

        [JsonProperty("fastDeliveryDeploy")]
        public bool FastDeliveryDeploy { get; set; }

        [JsonProperty("gtmDelay2000")]
        public bool GtmDelay2000 { get; set; }

        [JsonProperty("isCdnFonts")]
        public bool IsCdnFonts { get; set; }

        [JsonProperty("isModern")]
        public bool IsModern { get; set; }

        [JsonProperty("isRFBS")]
        public bool IsRFBS { get; set; }

        [JsonProperty("isStickySearchbar")]
        public bool IsStickySearchbar { get; set; }

        [JsonProperty("isTrinityEvent")]
        public bool IsTrinityEvent { get; set; }

        [JsonProperty("newOrderDone")]
        public bool NewOrderDone { get; set; }

        [JsonProperty("s3PublicPath")]
        public bool S3PublicPath { get; set; }

        [JsonProperty("trackCdnImages")]
        public bool TrackCdnImages { get; set; }

        [JsonProperty("withTwoButtons")]
        public bool WithTwoButtons { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}