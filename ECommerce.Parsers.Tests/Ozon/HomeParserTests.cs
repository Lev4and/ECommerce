using ECommerce.HttpClients;
using ECommerce.Parsers.Extensions;
using FluentAssertions;
using System.Threading.Tasks;
using Xunit;

namespace ECommerce.Parsers.Tests.Ozon
{
    public class HomeParserTests
    {
        private readonly HttpContext _httpContext;
        private readonly ParserContext _parserContext;

        public HomeParserTests(HttpContext httpContext, ParserContext parserContext)
        {
            _httpContext = httpContext;
            _parserContext = parserContext;
        }

        [Fact]
        public async Task GetCategories_ReturnNotBeNullOrEmptyCollection()
        {
            var homePage = await _httpContext.Ozon.Home.GetHomePageAsync();
            var document = await homePage.GetHtmlDocumentAsync();

            var collection = _parserContext.Ozon.Home.GetCategories(document);

            collection.Should().NotBeEmpty();
            collection.Should().HaveCountGreaterThan(0);
        }
    }
}
