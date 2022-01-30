using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class FavoriteProductMolecule
    {
        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("isFavorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("favoriteButton")]
        public FavoriteButton FavoriteButton { get; set; }

        [JsonProperty("unfavoriteButton")]
        public UnfavoriteButton UnfavoriteButton { get; set; }

        [JsonProperty("addToListAction")]
        public AddToListAction AddToListAction { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}