using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class WidgetTrackingInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("vertical")]
        public string Vertical { get; set; }

        [JsonProperty("component")]
        public string Component { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("revisionId")]
        public int RevisionId { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("originName")]
        public string OriginName { get; set; }

        [JsonProperty("originVertical")]
        public string OriginVertical { get; set; }

        [JsonProperty("originComponent")]
        public string OriginComponent { get; set; }

        [JsonProperty("originVersion")]
        public int? OriginVersion { get; set; }

        [JsonProperty("configId")]
        public int? ConfigId { get; set; }

        [JsonProperty("configDtId")]
        public int? ConfigDtId { get; set; }

        [JsonProperty("dtName")]
        public string DtName { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}