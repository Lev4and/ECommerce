using ECommerce.HttpClients.Ozon.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.ResourceWebApplication.Controllers 
{
    [ApiController]
    [Route("api/category")]
    [Produces("application/json")]
    public class CategoryController : ControllerBase
    {
        private readonly ECommerce.HttpClients.HttpContext _httpContext;

        public CategoryController(ECommerce.HttpClients.HttpContext httpContext)
        {
            _httpContext = httpContext;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Category), 200)]
        public async Task<IActionResult> Index()
        {
            return Ok(await _httpContext.Ozon.Category.GetCategoryAsync(0));
        }

        [HttpGet]
        [Route("{categoryId}")]
        [ProducesResponseType(typeof(Category), 200)]
        public async Task<IActionResult> Index([Required][FromRoute] int categoryId)
        {
            if (categoryId > 0)
            {
                return Ok(await _httpContext.Ozon.Category.GetCategoryAsync(categoryId));
            }

            return BadRequest();
        }
    }
}

