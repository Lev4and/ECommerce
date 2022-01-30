using Newtonsoft.Json;

namespace ECommerce.Model.Marketplace.Ozon.Types
{
    public class ContentReview
    {
        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("positive")]
        public string Positive { get; set; }

        [JsonProperty("negative")]
        public string Negative { get; set; }

        [JsonProperty("photos")]
        public List<Photo> Photos { get; set; }

        [JsonProperty("videos")]
        public List<object> Videos { get; set; }

        [JsonProperty("contextQuestions")]
        public List<ContextQuestion> ContextQuestions { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
