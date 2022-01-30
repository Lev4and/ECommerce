namespace ECommerce.Parsers.Ozon
{
    public class OzonParserContext
    {
        public HomeParser Home { get; }

        public OzonParserContext(HomeParser home)
        {
            Home = home;
        }
    }
}
