using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class PhotoClick
    {
        [JsonProperty("0")]
        public PhotoClickItem PhotoClickItem0 { get; set; }

        [JsonProperty("1")]
        public PhotoClickItem PhotoClickItem1 { get; set; }

        [JsonProperty("2")]
        public PhotoClickItem PhotoClickItem2 { get; set; }

        [JsonProperty("3")]
        public PhotoClickItem PhotoClickItem3 { get; set; }

        [JsonProperty("4")]
        public PhotoClickItem PhotoClickItem4 { get; set; }

        [JsonProperty("5")]
        public PhotoClickItem PhotoClickItem5 { get; set; }

        [JsonProperty("6")]
        public PhotoClickItem PhotoClickItem6 { get; set; }

        [JsonProperty("7")]
        public PhotoClickItem PhotoClickItem7 { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}