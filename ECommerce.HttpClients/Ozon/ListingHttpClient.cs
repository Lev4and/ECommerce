using ECommerce.HttpClients.Common.Extensions;
using ECommerce.HttpClients.Ozon.ResponseModels;

namespace ECommerce.HttpClients.Ozon
{
    public class ListingHttpClient : OzonHttpClient
    {
        public ListingHttpClient() : base(OzonRoutes.ListingPath)
        {

        }

        public async Task<string> GetStringListingAsync(string categoryUrl, int page, string filters)
        {
            if (string.IsNullOrEmpty(categoryUrl))
            {
                throw new ArgumentNullException("categoryUrl", "The category url must not be empty.");
            }

            if (page <= 0 && page > 278)
            {
                throw new ArgumentOutOfRangeException("page", "The page number must not be less than or equal to zero and more than 278.");
            }

            if (filters == null)
            {
                throw new ArgumentNullException("filters", "The filters must not be empty.");
            }

            UseHeaders(OzonHeaders.JsonHeaders);
            UseCookie();

            return await (await Client.GetAsync($"{OzonRoutes.ListingQuery}?url={categoryUrl}&page={page}&" +
                $"{filters}&page_changed=true")).GetStringResultAsync();
        }

        public async Task<Listing> GetListingAsync(string categoryUrl, int page, string filters)
        {
            if (string.IsNullOrEmpty(categoryUrl))
            {
                throw new ArgumentNullException("categoryUrl", "The category url must not be empty.");
            }

            if (page <= 0 && page > 278)
            {
                throw new ArgumentOutOfRangeException("page", "The page number must not be less than or equal to zero and more than 278.");
            }

            if (filters == null)
            {
                throw new ArgumentNullException("filters", "The filters must not be empty.");
            }

            return (await GetStringListingAsync(categoryUrl, page, filters)).GetJsonResult<Listing>();
        }

        public async Task<string> GetStringSearchSuggestionsAsync(string categoryUrl = "", string searchString = "")
        {
            UseHeaders(OzonHeaders.JsonHeaders);
            UseCookie();

            return await (await Client.GetAsync($"{OzonRoutes.SearchSuggestionsQuery}?text={searchString ?? ""}&" +
                $"url={(!string.IsNullOrEmpty(categoryUrl) ? categoryUrl : "/search/")}?text={"{value}"}" +
                    $"{(!string.IsNullOrEmpty(categoryUrl) ? "" : "&from_global=true")}"))
                        .GetStringResultAsync();
        }

        public async Task<SearchSuggestions> GetSearchSuggestionsAsync(string categoryUrl = "", string searchString = "")
        {
            return (await GetStringSearchSuggestionsAsync(categoryUrl, searchString)).GetJsonResult<SearchSuggestions>();
        }

        public async Task<string> GetStringAllFiltersAsync(string categoryUrl)
        {
            if (string.IsNullOrEmpty(categoryUrl))
            {
                throw new ArgumentNullException("categoryUrl", "The category url must not be empty.");
            }

            UseHeaders(OzonHeaders.JsonHeaders);
            UseCookie();

            return await (await Client.GetAsync($"{OzonRoutes.AllFiltersQuery}{categoryUrl}" +
                $"?page_changed=true")).GetStringResultAsync();
        }

        public async Task<AllFilters> GetAllFiltersAsync(string categoryUrl)
        {
            if (string.IsNullOrEmpty(categoryUrl))
            {
                throw new ArgumentNullException("categoryUrl", "The category url must not be empty.");
            }

            return (await GetStringAllFiltersAsync(categoryUrl)).GetJsonResult<AllFilters>();
        }
    }
}
