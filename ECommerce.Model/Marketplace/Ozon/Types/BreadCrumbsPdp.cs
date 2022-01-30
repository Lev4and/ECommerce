using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class BreadCrumbsPdp
    {
        [JsonProperty("breadCrumbs")]
        public List<BreadCrumb> BreadCrumbs { get; set; }

        [JsonProperty("breadCrumbConnectSymbol")]
        public string BreadCrumbConnectSymbol { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}