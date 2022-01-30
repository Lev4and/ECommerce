using Newtonsoft.Json;

namespace ECommerce.Model.Marketplace.Ozon.Types
{
    public class Product2
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("availability")]
        public int Availability { get; set; }

        [JsonProperty("stock")]
        public int Stock { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("finalPrice")]
        public int FinalPrice { get; set; }

        [JsonProperty("deliverySchema")]
        public string DeliverySchema { get; set; }

        [JsonProperty("marketplaceSellerId")]
        public int MarketplaceSellerId { get; set; }

        [JsonProperty("sellerId")]
        public int SellerId { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("brandId")]
        public int BrandId { get; set; }

        [JsonProperty("availableInDays")]
        public int AvailableInDays { get; set; }

        [JsonProperty("freeRest")]
        public int FreeRest { get; set; }

        [JsonProperty("stockCount")]
        public int StockCount { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }

        [JsonProperty("marketingActionIds")]
        public List<long> MarketingActionIds { get; set; }

        [JsonProperty("isPersonalized")]
        public bool IsPersonalized { get; set; }

        [JsonProperty("deliveryTimeDiffDays")]
        public int DeliveryTimeDiffDays { get; set; }

        [JsonProperty("isSupermarket")]
        public bool IsSupermarket { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("countItems")]
        public int CountItems { get; set; }

        [JsonProperty("adv_second_bid")]
        public string AdvSecondBid { get; set; }

        [JsonProperty("adv_second_bid_2")]
        public string AdvSecondBid2 { get; set; }

        [JsonProperty("availableDeliverySchema")]
        public List<int> AvailableDeliverySchema { get; set; }

        [JsonProperty("credit_product_type")]
        public string CreditProductType { get; set; }

        [JsonProperty("credit_product_price")]
        public int CreditProductPrice { get; set; }

        [JsonProperty("isFastDelivery")]
        public bool IsFastDelivery { get; set; }

        [JsonProperty("tileType")]
        public int TileType { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("totalQuantity")]
        public int TotalQuantity { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("labels")]
        public List<Label> Labels { get; set; }

        [JsonProperty("advId")]
        public string AdvId { get; set; }

        [JsonProperty("advert")]
        public string Advert { get; set; }

        [JsonProperty("checked")]
        public bool Checked { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
