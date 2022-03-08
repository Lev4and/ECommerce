using FluentAssertions;
using System.Threading.Tasks;
using Xunit;

namespace ECommerce.HttpClients.Tests.Ozon
{
    public class ListingHttpClientTests
    {
        private readonly HttpContext _httpContext;

        public ListingHttpClientTests(HttpContext httpContext)
        {
            _httpContext = httpContext;
        }

        [Fact]
        public async Task GetListingAsync_WithCategoryUrlAndPageParams_ReturnNotBeNullResponse()
        {
            var response = await _httpContext.Ozon.Listing.GetListingAsync("/category/noutbuki-15692/", 1, "delivery=2", 
                "price");

            response.Should().NotBeNull();
        }

        [Fact]
        public async Task GetSearchSuggestionsAsync_WithCategoryUrlAndSearchStringParams_ReturnNotBeNullResponse()
        {
            var response = await _httpContext.Ozon.Listing.GetSearchSuggestionsAsync("/category/noutbuki-15692/", "MSI");

            response.Should().NotBeNull();
        }

        [Fact]
        public async Task GetAllFiltersAsync_WithCategoryUrlParam_ReturnNotBeNullResponse()
        {
            var response = await _httpContext.Ozon.Listing.GetAllFiltersAsync("/category/noutbuki-15692/");

            response.Should().NotBeNull();
        }
    }
}
