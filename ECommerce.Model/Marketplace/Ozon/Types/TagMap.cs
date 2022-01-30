using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class TagMap
    {
        [JsonProperty("Authentication_0")]
        public Authentication Authentication0 { get; set; }

        [JsonProperty("Brand_0")]
        public Brand0 Brand0 { get; set; }

        [JsonProperty("NavigationOS_0")]
        public NavigationOS0 NavigationOS0 { get; set; }

        [JsonProperty("NumSIM_0")]
        public NumSIM0 NumSIM0 { get; set; }

        [JsonProperty("RAM_0")]
        public RAM0 RAM0 { get; set; }

        [JsonProperty("VolumeMemory_0")]
        public VolumeMemory0 VolumeMemory0 { get; set; }

        [JsonProperty("WirelessTechShort_0")]
        public WirelessTechShort0 WirelessTechShort0 { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}