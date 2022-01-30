using ECommerce.HttpClients.Ozon;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.HttpClients.Tests
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<CategoryHttpClient>();
            services.AddSingleton<HomeHttpClient>();
            services.AddSingleton<ListingHttpClient>();
            services.AddSingleton<ProductHttpClient>();
            services.AddSingleton<OzonHttpContext>();

            services.AddSingleton<HttpContext>();
        }
    }
}
