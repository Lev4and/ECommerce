using ECommerce.HttpClients.Ozon.ResponseModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.ResourceWebApplication.Controllers
{
    [ApiController]
    [Route("api/product")]
    [EnableCors("CorsPolicy")]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        private readonly ECommerce.HttpClients.HttpContext _httpContext;

        public ProductController(ECommerce.HttpClients.HttpContext httpContext)
        {
            _httpContext = httpContext;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Product), 200)]
        public async Task<IActionResult> Index([Required][FromQuery(Name = "url")] string productUrl)
        {
            if (!string.IsNullOrEmpty(productUrl))
            {
                return Ok(await _httpContext.Ozon.Product.GetProductAsync(productUrl));
            }

            return BadRequest();
        }

        [HttpGet("characteristics")]
        [ProducesResponseType(typeof(Product), 200)]
        public async Task<IActionResult> Characteristics([Required][FromQuery(Name = "url")] string productUrl)
        {
            if (!string.IsNullOrEmpty(productUrl))
            {
                return Ok(await _httpContext.Ozon.Product.GetProductCharacteristicsAsync(productUrl));
            }

            return BadRequest();
        }

        [HttpGet("reviews")]
        [ProducesResponseType(typeof(Product), 200)]
        public async Task<IActionResult> Reviews([Required][FromQuery(Name = "url")] string productUrl)
        {
            if (!string.IsNullOrEmpty(productUrl))
            {
                return Ok(await _httpContext.Ozon.Product.GetProductReviewsAsync(productUrl));
            }

            return BadRequest();
        }

        [HttpGet]
        [Route("reviews/list")]
        [ProducesResponseType(typeof(Reviews), 200)]
        public async Task<IActionResult> ReviewsListing([Required][FromQuery(Name = "url")] string productUrl, [Required][FromQuery(Name = "async_data")] string asyncData, [Required][FromQuery(Name = "p")] int page)
        {
            if (!string.IsNullOrEmpty(productUrl) || !string.IsNullOrEmpty(asyncData) || page > 0)
            {
                return Ok(await _httpContext.Ozon.Product.GetProductReviewsAsync(productUrl, asyncData, page));
            }

            return BadRequest();
        }
    }
}
