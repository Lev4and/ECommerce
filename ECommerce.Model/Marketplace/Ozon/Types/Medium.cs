using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Medium
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("reviewId")]
        public int ReviewId { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("previewUrl")]
        public string PreviewUrl { get; set; }

        [JsonProperty("shortVideoPreview")]
        public string ShortVideoPreview { get; set; }

        [JsonProperty("alt")]
        public object Alt { get; set; }

        [JsonProperty("viewsCount")]
        public object ViewsCount { get; set; }

        [JsonProperty("videoDuration")]
        public string VideoDuration { get; set; }

        [JsonProperty("size")]
        public Size Size { get; set; }

        [JsonProperty("sharing")]
        public Sharing Sharing { get; set; }

        [JsonProperty("commentsButton")]
        public object CommentsButton { get; set; }

        [JsonProperty("reviewsButton")]
        public object ReviewsButton { get; set; }

        [JsonProperty("author")]
        public object Author { get; set; }

        [JsonProperty("trackingInfo")]
        public TrackingInfo TrackingInfo { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}