using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Atom
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("textAtom")]
        public TextAtom TextAtom { get; set; }

        [JsonProperty("rating")]
        public Rating Rating { get; set; }

        [JsonProperty("textVariants")]
        public TextVariants TextVariants { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }

        [JsonProperty("priceWithTitle")]
        public PriceWithTitle PriceWithTitle { get; set; }

        [JsonProperty("badge")]
        public Badge Badge { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}