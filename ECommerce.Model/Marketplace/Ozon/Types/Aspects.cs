using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Aspects
    {
        [JsonProperty("0_0")]
        public string _00 { get; set; }

        [JsonProperty("0_1")]
        public string _01 { get; set; }

        [JsonProperty("1_0")]
        public string _10 { get; set; }

        [JsonProperty("1_1")]
        public string _11 { get; set; }

        [JsonProperty("1_2")]
        public string _12 { get; set; }

        [JsonProperty("2_0")]
        public string _20 { get; set; }

        [JsonProperty("2_1")]
        public string _21 { get; set; }

        [JsonProperty("2_2")]
        public string _22 { get; set; }

        [JsonProperty("2_3")]
        public string _23 { get; set; }

        [JsonProperty("2_4")]
        public string _24 { get; set; }

        [JsonProperty("2_5")]
        public string _25 { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("descriptionRs")]
        public List<DescriptionR> DescriptionRs { get; set; }

        [JsonProperty("additionalInfo")]
        public AdditionalInfo AdditionalInfo { get; set; }

        [JsonProperty("variants")]
        public List<Variant> Variants { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}