using FluentAssertions;
using System.Threading.Tasks;
using Xunit;

namespace ECommerce.HttpClients.Tests.Ozon
{
    public class HomeHttpClientTests
    {
        private readonly HttpContext _httpContext;

        public HomeHttpClientTests(HttpContext httpContext)
        {
            _httpContext = httpContext;
        }

        [Fact]
        public async Task GetHomePageAsync_ReturnNotBeNullOrEmptyResponse()
        {
            var response = await _httpContext.Ozon.Home.GetHomePageAsync();

            response.Should().NotBeNullOrEmpty();
        }
    }
}
