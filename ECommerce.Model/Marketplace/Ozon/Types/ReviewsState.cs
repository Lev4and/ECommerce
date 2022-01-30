using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model.Marketplace.Ozon.Types
{
    public class ReviewsState
    {
        [JsonProperty("media")]
        public List<Medium> Media { get; set; }

        [JsonProperty("selectedIndex")]
        public int SelectedIndex { get; set; }

        [JsonProperty("reviews")]
        public Dictionary<string, Review> Reviews { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
