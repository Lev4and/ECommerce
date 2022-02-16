﻿using ECommerce.HttpClients.Ozon.ResponseModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.ResourceWebApplication.Controllers
{
    [ApiController]
    [Route("api/catalog")]
    [EnableCors("CorsPolicy")]
    [Produces("application/json")]
    public class CatalogController : ControllerBase
    {
        private readonly ECommerce.HttpClients.HttpContext _httpContext;

        public CatalogController(ECommerce.HttpClients.HttpContext httpContext)
        {
            _httpContext = httpContext;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Listing), 200)]
        public async Task<IActionResult> Index([Required][FromQuery(Name = "category_url")] string categoryUrl, [FromQuery(Name = "p")] int page = 1)
        {
            if (!string.IsNullOrEmpty(categoryUrl) && page > 0)
            {
                return Ok(await _httpContext.Ozon.Listing.GetListingAsync(categoryUrl, page));
            }

            return BadRequest();
        }

        [HttpGet("searchSuggestions")]
        [ProducesResponseType(typeof(SearchSuggestions), 200)]
        public async Task<IActionResult> SearchSuggestions([Required][FromQuery(Name = "category_url")] string categoryUrl, [Required][FromQuery(Name = "q")] string searchString)
        {
            if (!string.IsNullOrEmpty(categoryUrl) && !string.IsNullOrEmpty(searchString))
            {
                return Ok(await _httpContext.Ozon.Listing.GetSearchSuggestionsAsync(categoryUrl, searchString));
            }

            return BadRequest();
        }

        [HttpGet("allFilters")]
        [ProducesResponseType(typeof(AllFilters), 200)]
        public async Task<IActionResult> AllFilters([Required][FromQuery(Name = "category_url")] string categoryUrl)
        {
            if (!string.IsNullOrEmpty(categoryUrl))
            {
                return Ok(await _httpContext.Ozon.Listing.GetAllFiltersAsync(categoryUrl));
            }

            return BadRequest();
        }
    }
}
