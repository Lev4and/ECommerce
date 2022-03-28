namespace ECommerce.HttpClients.Ozon
{
    public class OzonRoutes
    {
        public const string Domain = "www.ozon.ru";

        public const string HomePath = "";

        public const string HomeQuery = "";

        public const string CategoryPath = "api/composer-api.bx/";

        public const string CategoryQuery = "_action/categoryChildV2";

        public const string ListingPath = "api/composer-api.bx/";

        public const string ListingQuery = "page/json/v2";

        public const string AllFiltersQuery = "page/json/v2?url=/modal/allFilters";

        public const string SearchSuggestionsQuery = "page/json/v2?url=/searchSuggestions/";

        public const string ProductPath = "api/composer-api.bx/";

        public const string ProductQuery = "page/json/v2";

        public const string ProductReviewsQuery = "widget/json/v2";

        public const string ProductCharacteristicsQuery = "page/json/v2";

        public const string ProductGetCommentsByReviewIdQuery = "_action/rpGetCommentsByReviewId";
    }
}
