using FluentAssertions;
using System.Threading.Tasks;
using Xunit;

namespace ECommerce.HttpClients.Tests.Ozon
{
    public class CategoryHttpClientTests
    {
        private readonly HttpContext _httpContext;

        public CategoryHttpClientTests(HttpContext httpContext)
        {
            _httpContext = httpContext;
        }

        [Fact]
        public async Task GetCategoryAsync_WithCategoryIdParam_ReturnNotBeNullResponse()
        {
            var response = await _httpContext.Ozon.Category.GetCategoryAsync(15500);

            response.Should().NotBeNull();
        }
    }
}
