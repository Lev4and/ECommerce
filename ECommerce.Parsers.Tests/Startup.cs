using ECommerce.HttpClients;
using ECommerce.HttpClients.Ozon;
using ECommerce.Parsers.Ozon;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Parsers.Tests
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

            services.AddSingleton<HomeParser>();
            services.AddSingleton<OzonParserContext>();

            services.AddSingleton<ParserContext>();
        }
    }
}
