using ECommerce.HttpClients.Common.Extensions;
using ECommerce.HttpClients.Ozon.RequestParams;
using ECommerce.HttpClients.Ozon.ResponseModels;
using Newtonsoft.Json;
using System.Text;

namespace ECommerce.HttpClients.Ozon
{
    public class ProductHttpClient : OzonHttpClient
    {
        public ProductHttpClient() : base(OzonRoutes.ProductPath)
        {

        }

        public async Task<string> GetStringProductAsync(string productUrl)
        {
            if (string.IsNullOrEmpty(productUrl))
            {
                throw new ArgumentNullException("productUrl", "The product url must not be empty.");
            }

            UseHeaders(OzonHeaders.JsonHeaders);
            UseCookie();

            return await (await Client.GetAsync($"{OzonRoutes.ProductQuery}?url={productUrl}&page_changed=true"))
                .GetStringResultAsync();
        }

        public async Task<Product> GetProductAsync(string productUrl)
        {
            if (string.IsNullOrEmpty(productUrl))
            {
                throw new ArgumentNullException("productUrl", "The product url must not be empty.");
            }

            return (await GetStringProductAsync(productUrl)).GetJsonResult<Product>();
        }

        public async Task<string> GetStringProductCharacteristicsAsync(string productUrl)
        {
            if (string.IsNullOrEmpty(productUrl))
            {
                throw new ArgumentNullException("productUrl", "The product url must not be empty.");
            }

            UseHeaders(OzonHeaders.JsonHeaders);
            UseCookie();

            return await (await Client.GetAsync($"{OzonRoutes.ProductCharacteristicsQuery}?url={productUrl}"))
                .GetStringResultAsync();
        }

        public async Task<Product> GetProductCharacteristicsAsync(string productUrl)
        {
            if (string.IsNullOrEmpty(productUrl))
            {
                throw new ArgumentNullException("productUrl", "The product url must not be empty.");
            }

            return (await GetStringProductCharacteristicsAsync(productUrl)).GetJsonResult<Product>();
        }

        public async Task<string> GetStringProductReviewsAsync(string productUrl)
        {
            if (string.IsNullOrEmpty(productUrl))
            {
                throw new ArgumentNullException("productUrl", "The product url must not be empty.");
            }

            UseHeaders(OzonHeaders.JsonHeaders);
            UseCookie();

            return await (await Client.GetAsync($"{OzonRoutes.ProductCharacteristicsQuery}?url={productUrl}"))
                .GetStringResultAsync();
        }

        public async Task<Product> GetProductReviewsAsync(string productUrl)
        {
            if (string.IsNullOrEmpty(productUrl))
            {
                throw new ArgumentNullException("productUrl", "The product url must not be empty.");
            }

            return (await GetStringProductReviewsAsync(productUrl)).GetJsonResult<Product>();
        }

        public async Task<string> GetStringProductReviewsAsync(string productUrl, string asyncData, int page)
        {
            if (string.IsNullOrEmpty(productUrl))
            {
                throw new ArgumentNullException("productUrl", "The product url must not be empty.");
            }

            if (string.IsNullOrEmpty(asyncData))
            {
                throw new ArgumentNullException("asyncData", "The async data must not be empty.");
            }

            if (page <= 0)
            {
                throw new ArgumentOutOfRangeException("page", "The page number must not be less than or equal to zero.");
            }

            UseHeaders(OzonHeaders.JsonHeaders);
            UseCookie();

            return await (await Client.PostAsync($"{OzonRoutes.ProductReviewsQuery}",
                new StringContent(JsonConvert.SerializeObject(new LoadComponentRequestBody(productUrl, asyncData,
                    OzonComponents.ReviewsDesktop, page)), Encoding.UTF8, "application/json"))).GetStringResultAsync();
        }

        public async Task<Reviews> GetProductReviewsAsync(string productUrl, string asyncData, int page)
        {
            if (string.IsNullOrEmpty(productUrl))
            {
                throw new ArgumentNullException("productUrl", "The product url must not be empty.");
            }

            if (string.IsNullOrEmpty(asyncData))
            {
                throw new ArgumentNullException("asyncData", "The async data must not be empty.");
            }

            if (page <= 0)
            {
                throw new ArgumentOutOfRangeException("page", "The page number must not be less than or equal to zero.");
            }

            return (await GetStringProductReviewsAsync(productUrl, asyncData, page)).GetJsonResult<Reviews>();
        }

        public async Task<string> GetStringGetCommentsByReviewIdAsync(int reviewId, int limit, int offset)
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

            UseHeaders(OzonHeaders.JsonHeaders);
            UseCookie();

            return await (await Client.PostAsync($"{OzonRoutes.ProductGetCommentsByReviewIdQuery}",
                new StringContent(JsonConvert.SerializeObject(new GetCommentsByReviewIdRequestBody(reviewId, limit, offset)),
                    Encoding.UTF8, "application/json"))).GetStringResultAsync();
        }

        public async Task<CommentsByReview> GetCommentsByReviewIdAsync(int reviewId, int limit, int offset)
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

            return (await GetStringGetCommentsByReviewIdAsync(reviewId, limit, offset)).GetJsonResult<CommentsByReview>();
        }
    }
}
