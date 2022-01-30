using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class TopRightButton
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("favoriteProductMolecule")]
        public FavoriteProductMolecule FavoriteProductMolecule { get; set; }

        [JsonProperty("smallIconButton")]
        public SmallIconButton SmallIconButton { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}