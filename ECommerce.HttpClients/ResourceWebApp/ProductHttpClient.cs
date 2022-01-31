using ECommerce.HttpClients.Common.Extensions;
using ECommerce.HttpClients.Ozon.ResponseModels;

namespace ECommerce.HttpClients.ResourceWebApp
{
    public class ProductHttpClient : ResourceWebAppHttpClient
    {
        public ProductHttpClient() : base(ResourceWebAppRoutes.CategoryPath)
        {

        }

        public async Task<Product> GetProductAsync(string productUrl)
        {
            if (string.IsNullOrEmpty(productUrl))
            {
                throw new ArgumentNullException("productUrl", "The product url must not be empty.");
            }

            return await (await Client.GetAsync($"{ResourceWebAppRoutes.ProductQuery}?url={productUrl}"))
                .GetJsonResultAsync<Product>();
        }

        public async Task<Product> GetProductCharacteristicsAsync(string productUrl)
        {
            if (string.IsNullOrEmpty(productUrl))
            {
                throw new ArgumentNullException("productUrl", "The product url must not be empty.");
            }

            return await (await Client.GetAsync($"{ResourceWebAppRoutes.ProductCharacteristicsQuery}?url={productUrl}"))
                .GetJsonResultAsync<Product>();
        }

        public async Task<Product> GetProductReviewsAsync(string productUrl)
        {
            if (string.IsNullOrEmpty(productUrl))
            {
                throw new ArgumentNullException("productUrl", "The product url must not be empty.");
            }

            return await (await Client.GetAsync($"{ResourceWebAppRoutes.ProductReviewsQuery}?url={productUrl}"))
                .GetJsonResultAsync<Product>();
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

            return await (await Client.GetAsync($"{ResourceWebAppRoutes.ProductReviewsListingQuery}?url={productUrl}&" +
                $"async_data={asyncData}&p={page}")).GetJsonResultAsync<Reviews>();
        }
    }
}
