namespace ECommerce.HttpClients.ResourceWebApp
{
    public class ResourceWebAppHttpContext
    {
        public CatalogHttpClient Catalog { get; }

        public CategoryHttpClient Category { get; }

        public ProductHttpClient Product { get; }

        public ResourceWebAppHttpContext(CatalogHttpClient catalog, CategoryHttpClient category, ProductHttpClient product)
        {
            Catalog = catalog;
            Category = category;
            Product = product;
        }
    }
}
