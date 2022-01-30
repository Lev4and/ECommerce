using ECommerce.HttpClients.Common;

namespace ECommerce.HttpClients.Ozon
{
    public class OzonHttpClient : BaseHttpClient
    {
        public OzonHttpClient(string path) : base($"https://{OzonRoutes.Domain}/{path}")
        {
            if (path == null)
            {
                throw new ArgumentNullException("path", "The path should not be empty.");
            }
        }

        protected override void UseCookie()
        {
            base.UseCookie();

            Client.DefaultRequestHeaders.Add("Cookie", GetCookiesString($"https://{OzonRoutes.Domain}/"));
        }
    }
}
