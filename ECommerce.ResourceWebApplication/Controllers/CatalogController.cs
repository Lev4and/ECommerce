﻿using ECommerce.HttpClients.Ozon.ResponseModels;
using ECommerce.ResourceWebApplication.Models;
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

        [HttpPost]
        [ProducesResponseType(typeof(Listing), 200)]
        public async Task<IActionResult> Index([FromBody] CatalogRequestModel requestModel)
        {
            if (requestModel != null)
            {
                return Ok(await _httpContext.Ozon.Listing.GetListingAsync(requestModel.CategoryUrl, 
                    requestModel.Page, requestModel.Filters));
            }
                
            return BadRequest();
        }

        [HttpPost("searchSuggestions")]
        [ProducesResponseType(typeof(SearchSuggestions), 200)]
        public async Task<IActionResult> SearchSuggestions([FromBody] SearchSuggestionsRequestModel requestModel)
        {
            if(requestModel != null)
            {
                return Ok(await _httpContext.Ozon.Listing.GetSearchSuggestionsAsync(requestModel.CategoryUrl, requestModel.SearchString));
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
