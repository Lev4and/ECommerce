using ECommerce.HttpClients.Ozon;

namespace ECommerce.HttpClients
{
    public class HttpContext
    {
        public OzonHttpContext Ozon { get; }

        public HttpContext(OzonHttpContext ozon)
        {
            Ozon = ozon;
        }
    }
}
