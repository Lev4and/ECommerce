using AngleSharp.Dom;

namespace ECommerce.Parsers.Extensions
{
    public static class CategoryExtensions
    {
        public static int GetCategoryId(this IElement element)
        {
            return Convert.ToInt32(element.GetCategoryUrl().Substring(element.GetCategoryUrl()
                .LastIndexOf('-') + 1).TrimEnd('/'));
        }

        public static string GetCategoryUrl(this IElement element)
        {
            return element.GetAttribute("href");
        }

        public static string GetCategoryName(this IElement element)
        {
            return element.QuerySelector("span.b6m").InnerHtml;
        }
    }
}
