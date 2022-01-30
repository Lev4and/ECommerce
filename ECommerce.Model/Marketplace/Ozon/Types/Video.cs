using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Video
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("youtubeId")]
        public string YoutubeId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uploadId")]
        public object UploadId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("previewUrl")]
        public string PreviewUrl { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("galleryParams")]
        public string GalleryParams { get; set; }

        [JsonProperty("sharing")]
        public Sharing Sharing { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}