using ECommerce.HttpClients.Common.Extensions;
using ECommerce.HttpClients.Ozon.ResponseModels;

namespace ECommerce.HttpClients.ResourceWebApp
{
    public class CatalogHttpClient : ResourceWebAppHttpClient
    {
        public CatalogHttpClient() : base(ResourceWebAppRoutes.CatalogPath)
        {

        }

        public async Task<Listing> GetCatalogAsync(string categoryUrl, int page = 1)
        {
            if (string.IsNullOrEmpty(categoryUrl))
            {
                throw new ArgumentNullException("categoryUrl", "The category url must not be empty.");
            }

            if (page <= 0 && page > 278)
            {
                throw new ArgumentOutOfRangeException("page", "The page number must not be less than or equal to zero and more than 278.");
            }

            return await (await Client.GetAsync($"?category_url={categoryUrl}&p={page}")).GetJsonResultAsync<Listing>();
        }
    }
}
