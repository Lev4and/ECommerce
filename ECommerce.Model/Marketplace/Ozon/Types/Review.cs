using Newtonsoft.Json;

namespace ECommerce.Model.Marketplace.Ozon.Types
{
    public class Review
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("createdAt")]
        public int CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public object UpdatedAt { get; set; }

        [JsonProperty("itemId")]
        public int ItemId { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("isAbuseReported")]
        public bool IsAbuseReported { get; set; }

        [JsonProperty("isReportable")]
        public bool IsReportable { get; set; }

        [JsonProperty("isVotable")]
        public bool IsVotable { get; set; }

        [JsonProperty("isDeletable")]
        public bool IsDeletable { get; set; }

        [JsonProperty("isEditable")]
        public bool IsEditable { get; set; }

        [JsonProperty("isEdited")]
        public bool IsEdited { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("usefulness")]
        public Usefulness Usefulness { get; set; }

        [JsonProperty("statusId")]
        public int StatusId { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("isRejected")]
        public bool IsRejected { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("isAnchor")]
        public object IsAnchor { get; set; }

        [JsonProperty("isCommentable")]
        public bool IsCommentable { get; set; }

        [JsonProperty("isUserReview")]
        public bool IsUserReview { get; set; }

        [JsonProperty("isItemPurchased")]
        public bool IsItemPurchased { get; set; }

        [JsonProperty("isAnonymous")]
        public bool IsAnonymous { get; set; }

        [JsonProperty("content")]
        public ContentReview Content { get; set; }

        [JsonProperty("comments")]
        public Comments Comments { get; set; }

        [JsonProperty("editUrl")]
        public string EditUrl { get; set; }

        [JsonProperty("sharing")]
        public object Sharing { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
