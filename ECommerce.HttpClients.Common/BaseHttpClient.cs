using System.Net;

namespace ECommerce.HttpClients.Common
{
    public class BaseHttpClient
    {
        protected internal HttpClient Client { get; set; }

        protected internal CookieContainer Cookie { get; set; }

        protected internal HttpClientHandler Handler { get; set; }

        public BaseHttpClient(string uri)
        {
            if (string.IsNullOrEmpty(uri))
            {
                throw new ArgumentNullException("uri", "The server uri must not be empty.");
            }

            Cookie = new CookieContainer();
            Handler = new HttpClientHandler();

            Handler.AllowAutoRedirect = true;
            Handler.CookieContainer = Cookie;
            Handler.AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate | System.Net.DecompressionMethods.Brotli;
            Handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };

            Client = new HttpClient(Handler);
            Client.BaseAddress = new Uri(uri);
        }

        protected internal void UseHeaders(Dictionary<string, string> headers)
        {
            if(headers == null)
            {
                throw new ArgumentNullException("headers", "The headers must not be empty.");
            }

            Client.DefaultRequestHeaders.Clear();

            foreach(var header in headers)
            {
                Client.DefaultRequestHeaders.Add(header.Key, header.Value);
            }
        }

        protected internal virtual void UseCookie()
        {
            Client.DefaultRequestHeaders.Remove("Cookie");
        }

        protected internal void GetCookies(string uri)
        {
            if (string.IsNullOrEmpty(uri))
            {
                throw new ArgumentNullException("uri", "The server uri must not be empty.");
            }

            Handler.CookieContainer.GetCookies(new Uri($"{uri}")).Cast<Cookie>().ToList();
        }

        protected internal string GetCookiesString(string uri)
        {
            if (string.IsNullOrEmpty(uri))
            {
                throw new ArgumentNullException("uri", "The server uri must not be empty.");
            }

            return String.Join(';', Handler.CookieContainer.GetCookies(new Uri($"{uri}")).Cast<Cookie>()
                .Select(keyValuePair => $"{keyValuePair.Name}={keyValuePair.Value}"));
        }
    }
}
