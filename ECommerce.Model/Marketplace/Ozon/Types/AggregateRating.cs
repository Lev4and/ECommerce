using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class AggregateRating
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("ratingValue")]
        public string RatingValue { get; set; }

        [JsonProperty("reviewCount")]
        public string ReviewCount { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}