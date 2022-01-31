using ECommerce.HttpClients.Ozon;
using ECommerce.HttpClients.ResourceWebApp;

namespace ECommerce.HttpClients
{
    public class HttpContext
    {
        public OzonHttpContext Ozon { get; }

        public ResourceWebAppHttpContext ResourceWebApp { get; }

        public HttpContext(OzonHttpContext ozon, ResourceWebAppHttpContext resourceWebApp)
        {
            Ozon = ozon;
            ResourceWebApp = resourceWebApp;
        }
    }
}
