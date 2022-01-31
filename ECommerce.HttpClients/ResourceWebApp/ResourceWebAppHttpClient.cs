using ECommerce.HttpClients.Common;

namespace ECommerce.HttpClients.ResourceWebApp
{
    public class ResourceWebAppHttpClient : BaseHttpClient
    {
        public ResourceWebAppHttpClient(string path) : base($"https://{ResourceWebAppRoutes.Domain}/api/{path}")
        {
            if (path == null)
            {
                throw new ArgumentNullException("path", "The path should not be empty.");
            }
        }
    }
}
