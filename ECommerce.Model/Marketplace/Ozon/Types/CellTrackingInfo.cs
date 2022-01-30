using Newtonsoft.Json;

namespace ECommerce.Model.Marketplace.Ozon.Types
{
    public class CellTrackingInfo
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("countItems")]
        public int CountItems { get; set; }

        [JsonProperty("finalPrice")]
        public int FinalPrice { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("cartType")]
        public string CartType { get; set; }

        [JsonProperty("elementType")]
        public string ElementType { get; set; }

        [JsonProperty("product")]
        public Product Product { get; set; }

        [JsonProperty("originalPrice")]
        public int OriginalPrice { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }

        [JsonProperty("sellerId")]
        public int SellerId { get; set; }

        [JsonProperty("brandId")]
        public int BrandId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("totalQuantity")]
        public int TotalQuantity { get; set; }

        [JsonProperty("products")]
        public Products Products { get; set; }

        [JsonProperty("uis")]
        public Uis Uis { get; set; }

        [JsonProperty("uiMap")]
        public UiMap UiMap { get; set; }

        [JsonProperty("productMap")]
        public ProductMap ProductMap { get; set; }

        [JsonProperty("aspects")]
        public Aspects Aspects { get; set; }

        [JsonProperty("brandMap")]
        public BrandMap BrandMap { get; set; }

        [JsonProperty("tagMap")]
        public TagMap TagMap { get; set; }

        [JsonProperty("seller")]
        public Seller Seller { get; set; }

        [JsonProperty("universal")]
        public Universal Universal { get; set; }

        [JsonProperty("ui")]
        public Ui Ui { get; set; }

        [JsonProperty("uiList")]
        public List<UiList> UiList { get; set; }

        [JsonProperty("photoClick")]
        public PhotoClick PhotoClick { get; set; }

        [JsonProperty("arrowClick")]
        public List<ArrowClick> ArrowClick { get; set; }

        [JsonProperty("widgetSwipe")]
        public WidgetSwipe WidgetSwipe { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("popup")]
        public Popup Popup { get; set; }

        [JsonProperty("sku")]
        public int Sku { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
