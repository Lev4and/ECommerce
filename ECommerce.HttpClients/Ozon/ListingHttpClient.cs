using ECommerce.HttpClients.Common.Extensions;
using ECommerce.HttpClients.Ozon.ResponseModels;

namespace ECommerce.HttpClients.Ozon
{
    public class ListingHttpClient : OzonHttpClient
    {
        public ListingHttpClient() : base(OzonRoutes.ListingPath)
        {

        }

        public async Task<string> GetStringListingAsync(string categoryUrl, int page)
        {
            if (string.IsNullOrEmpty(categoryUrl))
            {
                throw new ArgumentNullException("categoryUrl", "The category url must not be empty.");
            }

            if (page <= 0 && page > 278)
            {
                throw new ArgumentOutOfRangeException("page", "The page number must not be less than or equal to zero and more than 278.");
            }

            UseHeaders(OzonHeaders.JsonHeaders);
            UseCookie();

            return await (await Client.GetAsync($"{OzonRoutes.ListingQuery}?url={categoryUrl}&page={page}&" +
                $"page_changed=true")).GetStringResultAsync();
        }

        public async Task<Listing> GetListingAsync(string categoryUrl, int page)
        {
            if (string.IsNullOrEmpty(categoryUrl))
            {
                throw new ArgumentNullException("categoryUrl", "The category url must not be empty.");
            }

            if(page <= 0 && page > 278)
            {
                throw new ArgumentOutOfRangeException("page", "The page number must not be less than or equal to zero and more than 278.");
            }

            return (await GetStringListingAsync(categoryUrl, page)).GetJsonResult<Listing>();
        }

        public async Task<string> GetStringSearchSuggestionsAsync(string categoryUrl, string searchString)
        {
            if (string.IsNullOrEmpty(categoryUrl))
            {
                throw new ArgumentNullException("categoryUrl", "The category url must not be empty.");
            }

            if (string.IsNullOrEmpty(searchString))
            {
                throw new ArgumentNullException("searchString", "The search string must not be empty.");
            }

            UseHeaders(OzonHeaders.JsonHeaders);
            UseCookie();

            return await (await Client.GetAsync($"{OzonRoutes.SearchSuggestionsQuery}?text={searchString}&" +
                $"url={categoryUrl}?text={"{value}"}")).GetStringResultAsync();
        }

        public async Task<SearchSuggestions> GetSearchSuggestionsAsync(string categoryUrl, string searchString)
        {
            if (string.IsNullOrEmpty(categoryUrl))
            {
                throw new ArgumentNullException("categoryUrl", "The category url must not be empty.");
            }

            if (string.IsNullOrEmpty(searchString))
            {
                throw new ArgumentNullException("searchString", "The search string must not be empty.");
            }

            return (await GetStringSearchSuggestionsAsync(categoryUrl, searchString)).GetJsonResult<SearchSuggestions>();
        }
    }
}
