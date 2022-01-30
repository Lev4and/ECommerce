using ECommerce.HttpClients.Common.Extensions;
using ECommerce.HttpClients.Ozon.ResponseModels;

namespace ECommerce.HttpClients.Ozon
{
    public class CategoryHttpClient : OzonHttpClient
    {
        public CategoryHttpClient() : base(OzonRoutes.CategoryPath)
        {

        }

        public async Task<string> GetStringCategoryAsync(int categoryId)
        {
            UseHeaders(OzonHeaders.JsonHeaders);
            UseCookie();

            return await (await Client.GetAsync($"{OzonRoutes.CategoryQuery}?menuId=1&categoryId={categoryId}"))
                .GetStringResultAsync();
        }

        public async Task<Category> GetCategoryAsync(int categoryId)
        {
            return (await GetStringCategoryAsync(categoryId)).GetJsonResult<Category>();
        }
    }
}
