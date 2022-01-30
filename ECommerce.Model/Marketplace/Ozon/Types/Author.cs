using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Author
    {
        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("fio")]
        public string Fio { get; set; }

        [JsonProperty("clientOfficial")]
        public object ClientOfficial { get; set; }

        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}