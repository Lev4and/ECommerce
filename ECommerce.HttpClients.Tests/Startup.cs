using Microsoft.Extensions.DependencyInjection;
using OzonHttpClients = ECommerce.HttpClients.Ozon;
using ResourceWebAppHttpClients = ECommerce.HttpClients.ResourceWebApp;

namespace ECommerce.HttpClients.Tests
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<OzonHttpClients.CategoryHttpClient>();
            services.AddSingleton<OzonHttpClients.HomeHttpClient>();
            services.AddSingleton<OzonHttpClients.ListingHttpClient>();
            services.AddSingleton<OzonHttpClients.ProductHttpClient>();
            services.AddSingleton<OzonHttpClients.OzonHttpContext>();

            services.AddSingleton<ResourceWebAppHttpClients.CatalogHttpClient>();
            services.AddSingleton<ResourceWebAppHttpClients.CategoryHttpClient>();
            services.AddSingleton<ResourceWebAppHttpClients.ProductHttpClient>();
            services.AddSingleton<ResourceWebAppHttpClients.ResourceWebAppHttpContext>();

            services.AddSingleton<HttpContext>();
        }
    }
}
