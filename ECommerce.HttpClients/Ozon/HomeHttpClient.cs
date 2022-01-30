using ECommerce.HttpClients.Common.Extensions;

namespace ECommerce.HttpClients.Ozon
{
    public class HomeHttpClient : OzonHttpClient
    {
        public HomeHttpClient() : base(OzonRoutes.HomePath)
        {

        }

        public async Task<string> GetHomePageAsync()
        {
            UseHeaders(OzonHeaders.HtmlHeaders);

            return await (await Client.GetAsync(OzonRoutes.HomeQuery)).GetHtmlResultAsync();
        }
    }
}
