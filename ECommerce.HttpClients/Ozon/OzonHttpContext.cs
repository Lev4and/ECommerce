namespace ECommerce.HttpClients.Ozon
{
    public class OzonHttpContext
    {
        public HomeHttpClient Home { get; }

        public CategoryHttpClient Category { get; }
        
        public ListingHttpClient Listing { get; }
        
        public ProductHttpClient Product { get; }
        

        public OzonHttpContext(HomeHttpClient home, CategoryHttpClient category, ListingHttpClient listing, 
            ProductHttpClient product)
        {
            Home = home;
            Category = category;
            Listing = listing;
            Product = product;
        }
    }
}
