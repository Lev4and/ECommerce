using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Product
    {
        [JsonProperty("skuId")]
        public string SkuId { get; set; }

        [JsonProperty("images")]
        public List<string> Images { get; set; }

        [JsonProperty("imageBadges")]
        public List<ImageBadge> ImageBadges { get; set; }

        [JsonProperty("isAdult")]
        public bool IsAdult { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("state")]
        public List<State> State { get; set; }

        [JsonProperty("button")]
        public Button Button { get; set; }

        [JsonProperty("trackingInfo")]
        public TrackingInfo TrackingInfo { get; set; }

        [JsonProperty("isBiggest")]
        public bool IsBiggest { get; set; }

        [JsonProperty("alt")]
        public string Alt { get; set; }

        [JsonProperty("buttonSubtitle")]
        public ButtonSubtitle ButtonSubtitle { get; set; }

        [JsonProperty("topRightButtons")]
        public List<TopRightButton> TopRightButtons { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sku")]
        public int Sku { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("finalPrice")]
        public int FinalPrice { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }

        [JsonProperty("advId")]
        public string AdvId { get; set; }

        [JsonProperty("sellerId")]
        public int SellerId { get; set; }

        [JsonProperty("brandId")]
        public int BrandId { get; set; }

        [JsonProperty("brandName")]
        public string BrandName { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("totalQuantity")]
        public int TotalQuantity { get; set; }

        [JsonProperty("stock")]
        public int Stock { get; set; }

        [JsonProperty("stockCount")]
        public int StockCount { get; set; }

        [JsonProperty("storehouseId")]
        public long StorehouseId { get; set; }

        [JsonProperty("isSupermarket")]
        public bool IsSupermarket { get; set; }

        [JsonProperty("marketingActionIds")]
        public List<long> MarketingActionIds { get; set; }

        [JsonProperty("availableDeliverySchema")]
        public List<int> AvailableDeliverySchema { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}