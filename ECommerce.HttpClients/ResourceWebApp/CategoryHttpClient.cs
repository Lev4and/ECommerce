using ECommerce.HttpClients.Common.Extensions;
using ECommerce.HttpClients.Ozon.ResponseModels;

namespace ECommerce.HttpClients.ResourceWebApp
{
    public class CategoryHttpClient : ResourceWebAppHttpClient
    {
        public CategoryHttpClient() : base(ResourceWebAppRoutes.CategoryPath)
        {

        }

        public async Task<Category> GetCategoryAsync()
        {
            return await (await Client.GetAsync($"")).GetJsonResultAsync<Category>();
        }

        public async Task<Category> GetCategoryAsync(int categoryId)
        {
            return await (await Client.GetAsync($"{categoryId}")).GetJsonResultAsync<Category>();
        }
    }
}
