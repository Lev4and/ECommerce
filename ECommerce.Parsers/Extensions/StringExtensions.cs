using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;

namespace ECommerce.Parsers.Extensions
{
    public static class StringExtensions
    {
        public static async Task<IHtmlDocument> GetHtmlDocumentAsync(this string html)
        {
            if (string.IsNullOrEmpty(html))
            {
                throw new ArgumentNullException("html", "The html should not be empty.");
            }

            return await new HtmlParser().ParseDocumentAsync(html);
        }
    }
}
