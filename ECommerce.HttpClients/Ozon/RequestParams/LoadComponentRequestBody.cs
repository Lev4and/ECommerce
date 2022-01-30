using Newtonsoft.Json;

namespace ECommerce.HttpClients.Ozon.RequestParams
{
    public class LoadComponentRequestBody
    {
        [JsonProperty("url")]
        public string Url { get; }

        [JsonProperty("asyncData")]
        public string AsyncData { get; }

        [JsonProperty("componentName")]
        public string ComponentName { get; }

        [JsonProperty("extraBody")]
        public object ExtraBody => null;

        public LoadComponentRequestBody(string productUrl, string asyncData, string componentName, int page)
        {
            if (string.IsNullOrEmpty(productUrl))
            {
                throw new ArgumentNullException("productUrl", "The product url must not be empty.");
            }

            if (string.IsNullOrEmpty(asyncData))
            {
                throw new ArgumentNullException("asyncData", "The async data must not be empty.");
            }

            if (string.IsNullOrEmpty(componentName))
            {
                throw new ArgumentNullException("productUrl", "The component name must not be empty.");
            }

            if (page <= 0)
            {
                throw new ArgumentOutOfRangeException("page", "The page number must not be less than or equal to zero.");
            }

            Url = $"{productUrl}&page={page}&sort=usefulness_desc";
            AsyncData = asyncData;
            ComponentName = componentName;
        }
    }
}
