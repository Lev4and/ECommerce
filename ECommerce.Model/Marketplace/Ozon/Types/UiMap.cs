using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class UiMap
    {
        [JsonProperty("actionAddToCompare")]
        public ActionAddToCompare ActionAddToCompare { get; set; }

        [JsonProperty("actionRemoveFromCompare")]
        public ActionRemoveFromCompare ActionRemoveFromCompare { get; set; }

        [JsonProperty("click")]
        public Click Click { get; set; }

        [JsonProperty("view")]
        public View View { get; set; }

        [JsonProperty("bestPrice")]
        public BestPrice BestPrice { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("suggest")]
        public Suggest Suggest { get; set; }

        [JsonProperty("premiumSubscribe")]
        public PremiumSubscribe PremiumSubscribe { get; set; }

        [JsonProperty("clickDefault")]
        public ClickDefault ClickDefault { get; set; }

        [JsonProperty("ozonCard")]
        public OzonCard OzonCard { get; set; }

        [JsonProperty("copyLink")]
        public CopyLink CopyLink { get; set; }

        [JsonProperty("facebook")]
        public Facebook Facebook { get; set; }

        [JsonProperty("odnoklassniki")]
        public Odnoklassniki Odnoklassniki { get; set; }

        [JsonProperty("showList")]
        public ShowList ShowList { get; set; }

        [JsonProperty("telegram")]
        public Telegram Telegram { get; set; }

        [JsonProperty("twitter")]
        public Twitter Twitter { get; set; }

        [JsonProperty("vkontakte")]
        public Vkontakte Vkontakte { get; set; }

        [JsonProperty("content")]
        public Content Content { get; set; }

        [JsonProperty("richContent")]
        public RichContent RichContent { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}