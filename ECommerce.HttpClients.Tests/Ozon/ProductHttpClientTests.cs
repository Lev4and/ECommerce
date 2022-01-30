using FluentAssertions;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ECommerce.HttpClients.Tests.Ozon
{
    public class ProductHttpClientTests
    {
        private readonly HttpContext _httpContext;

        public ProductHttpClientTests(HttpContext httpContext)
        {
            _httpContext = httpContext;
        }

        [Fact]
        public async Task GetProductAsync_WithProductUrlParam_ReturnNotBeNullResponse()
        {
            var response = await _httpContext.Ozon.Product.GetProductAsync("/product/13-3-noutbuk-apple-macbook-air-" +
                "m1-apple-m1-3-2-ggts-ram-8-gb-ssd-512-gb-apple-m1-gpu-macos-z1240004j-249270178/?asb=0KRxtm68" +
                "Ac2%252F%252FpsDUV%252FfdGd2YDXmeM4ndCLzmfjeYY0%253D&amp;asb2=zQWS36_qQ-2cDSsu54hokRGKtffuo_9" +
                "X0tjujD_w6_rCr-P95CFK7ZTR9ORAIAyS");

            response.Should().NotBeNull();
        }

        [Fact]
        public async Task GetProductCharacteristicsAsync_WithProductUrlParam_ReturnNotBeNullResponse()
        {
            var product = await _httpContext.Ozon.Product.GetProductAsync("/product/13-3-noutbuk-apple-macbook-air-" +
                "m1-apple-m1-3-2-ggts-ram-8-gb-ssd-512-gb-apple-m1-gpu-macos-z1240004j-249270178/?asb=0KRxtm68" +
                "Ac2%252F%252FpsDUV%252FfdGd2YDXmeM4ndCLzmfjeYY0%253D&amp;asb2=zQWS36_qQ-2cDSsu54hokRGKtffuo_9" +
                "X0tjujD_w6_rCr-P95CFK7ZTR9ORAIAyS");

            var productCharacteristics = await _httpContext.Ozon.Product
                .GetProductCharacteristicsAsync(product.WidgetStates.Paginator.NextPage);

            product.Should().NotBeNull();
            productCharacteristics.Should().NotBeNull();
        }

        [Fact]
        public async Task GetProductReviewsAsync_WithProductUrlParam_ReturnNotBeNullResponse()
        {
            var product = await _httpContext.Ozon.Product.GetProductAsync("/product/13-3-noutbuk-apple-macbook-air-" +
                "m1-apple-m1-3-2-ggts-ram-8-gb-ssd-512-gb-apple-m1-gpu-macos-z1240004j-249270178/?asb=0KRxtm68" +
                "Ac2%252F%252FpsDUV%252FfdGd2YDXmeM4ndCLzmfjeYY0%253D&amp;asb2=zQWS36_qQ-2cDSsu54hokRGKtffuo_9" +
                "X0tjujD_w6_rCr-P95CFK7ZTR9ORAIAyS");

            var productCharacteristics = await _httpContext.Ozon.Product
                .GetProductCharacteristicsAsync(product.WidgetStates.Paginator.NextPage);

            var productReviews = await _httpContext.Ozon.Product
                .GetProductReviewsAsync(productCharacteristics.WidgetStates.PaginatorPdpPage2Column.NextPage);

            product.Should().NotBeNull();
            productReviews.Should().NotBeNull();
            productCharacteristics.Should().NotBeNull();
        }

        [Fact]
        public async Task GetProductReviewsAsync_WithRequestBodyParam_ReturnNotBeNullResponse()
        {
            var product = await _httpContext.Ozon.Product.GetProductAsync("/product/13-3-noutbuk-apple-macbook-air-" +
                "m1-apple-m1-3-2-ggts-ram-8-gb-ssd-512-gb-apple-m1-gpu-macos-z1240004j-249270178/?asb=0KRxtm68" +
                "Ac2%252F%252FpsDUV%252FfdGd2YDXmeM4ndCLzmfjeYY0%253D&amp;asb2=zQWS36_qQ-2cDSsu54hokRGKtffuo_9" +
                "X0tjujD_w6_rCr-P95CFK7ZTR9ORAIAyS");

            var asyncData = product.Layout.FirstOrDefault(layout => layout.Component == "webReviewGallery").AsyncData;

            var productCharacteristics = await _httpContext.Ozon.Product
                .GetProductCharacteristicsAsync(product.WidgetStates.Paginator.NextPage);

            var productReviews = await _httpContext.Ozon.Product
                .GetProductReviewsAsync(productCharacteristics.WidgetStates.PaginatorPdpPage2Column.NextPage);

            var reviews = await _httpContext.Ozon.Product
                .GetProductReviewsAsync(product.PageInfo.Url, asyncData, 1);

            reviews.Should().NotBeNull();
            product.Should().NotBeNull();
            productReviews.Should().NotBeNull();
            productCharacteristics.Should().NotBeNull();
        }
    }
}
