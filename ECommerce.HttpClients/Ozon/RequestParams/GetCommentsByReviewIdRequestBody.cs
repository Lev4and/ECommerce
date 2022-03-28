using Newtonsoft.Json;

namespace ECommerce.HttpClients.Ozon.RequestParams
{
    public class GetCommentsByReviewIdRequestBody
    {
        [JsonProperty("limit")]
        public int Limit { get; }

        [JsonProperty("offset")]
        public int Offset { get; }

        [JsonProperty("reviewId")]
        public int ReviewId { get; }

        public GetCommentsByReviewIdRequestBody(int reviewId, int limit, int offset)
        {
            if (reviewId <= 0)
            {
                throw new ArgumentOutOfRangeException("page", "The review id must not be less than or equal to zero.");
            }

            if (limit <= 0)
            {
                throw new ArgumentOutOfRangeException("limit", "The limit must not be less than or equal to zero.");
            }

            if (offset < 0)
            {
                throw new ArgumentOutOfRangeException("offset", "The offset must not be less than to zero.");
            }

            ReviewId = reviewId;
            Limit = limit;
            Offset = offset;
        }
    }
}
