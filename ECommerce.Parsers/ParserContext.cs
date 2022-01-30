using ECommerce.Parsers.Ozon;

namespace ECommerce.Parsers
{
    public class ParserContext
    {
        public OzonParserContext Ozon { get; }

        public ParserContext(OzonParserContext ozon)
        {
            Ozon = ozon;
        }
    }
}
