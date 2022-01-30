using Newtonsoft.Json; 
using System.Collections.Generic; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Item
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("align")]
        public string Align { get; set; }

        [JsonProperty("textAlign")]
        public string TextAlign { get; set; }

        [JsonProperty("textPosition")]
        public string TextPosition { get; set; }

        [JsonProperty("textColor")]
        public string TextColor { get; set; }

        [JsonProperty("textSize")]
        public string TextSize { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("deeplink")]
        public string Deeplink { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("cellTrackingInfo")]
        public CellTrackingInfo CellTrackingInfo { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("action")]
        public Action Action { get; set; }

        [JsonProperty("isAdult")]
        public bool IsAdult { get; set; }

        [JsonProperty("mainState")]
        public List<MainState> MainState { get; set; }

        [JsonProperty("multiButton")]
        public MultiButton MultiButton { get; set; }

        [JsonProperty("rightState")]
        public List<RightState> RightState { get; set; }

        [JsonProperty("tileImage")]
        public TileImage TileImage { get; set; }

        [JsonProperty("topRightButtons")]
        public List<TopRightButton> TopRightButtons { get; set; }

        [JsonProperty("trackingInfo")]
        public TrackingInfo TrackingInfo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("topup_id")]
        public string TopupId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}