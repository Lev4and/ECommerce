using AngleSharp.Html.Dom;
using ECommerce.Parsers.Extensions;
using ECommerce.Parsers.Ozon.Models;

namespace ECommerce.Parsers.Ozon
{
    public class HomeParser : BaseParser
    {
        public List<Category> GetCategories(IHtmlDocument document)
        {
            if(document != null)
            {
                return document.QuerySelectorAll("div.bm9 div.b9m a.rf5.mb5.mb6")
                .Where(item => item.GetAttribute("href").Contains("/category/"))
                .Select(item => new Category
                {
                    Id = item.GetCategoryId(),
                    Url = item.GetCategoryUrl(),
                    Name = item.GetCategoryName()
                })
                .ToList();
            }

            return new List<Category>();
        }
    }
}
