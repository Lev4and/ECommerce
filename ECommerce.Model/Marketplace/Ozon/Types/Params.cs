using Newtonsoft.Json; 

namespace ECommerce.Model.Marketplace.Ozon.Types
{ 
    public class Params
    {
        [JsonProperty("menuId")]
        public string MenuId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("onlyFinalCats")]
        public bool? OnlyFinalCats { get; set; }

        [JsonProperty("useMaxCountFromSeoTool")]
        public bool? UseMaxCountFromSeoTool { get; set; }

        [JsonProperty("itemsOnPage")]
        public int? ItemsOnPage { get; set; }

        [JsonProperty("lowerLimit")]
        public int? LowerLimit { get; set; }

        [JsonProperty("providerAlgo")]
        public string ProviderAlgo { get; set; }

        [JsonProperty("layoutContainer")]
        public string LayoutContainer { get; set; }

        [JsonProperty("offsetParamName")]
        public string OffsetParamName { get; set; }

        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("algo")]
        public string Algo { get; set; }

        [JsonProperty("showBuyButton")]
        public bool? ShowBuyButton { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("needCategoryInHeader")]
        public bool? NeedCategoryInHeader { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("isAdult")]
        public string IsAdult { get; set; }

        [JsonProperty("inOrNotIn")]
        public bool? InOrNotIn { get; set; }

        [JsonProperty("sellerList")]
        public List<int> SellerList { get; set; }

        [JsonProperty("triggeringObjectSelector")]
        public string TriggeringObjectSelector { get; set; }

        [JsonProperty("fetchType")]
        public string FetchType { get; set; }

        [JsonProperty("isContentVisibilityAuto")]
        public bool? IsContentVisibilityAuto { get; set; }

        [JsonProperty("minHeight")]
        public int? MinHeight { get; set; }

        [JsonProperty("offsetTop")]
        public int? OffsetTop { get; set; }

        [JsonProperty("reviewGalleryElementsLimit")]
        public int? ReviewGalleryElementsLimit { get; set; }

        [JsonProperty("showVideosParam")]
        public bool? ShowVideosParam { get; set; }

        [JsonProperty("alignCrossAxis")]
        public string AlignCrossAxis { get; set; }

        [JsonProperty("alignMainAxis")]
        public string AlignMainAxis { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("betweenMargin")]
        public string BetweenMargin { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("horizontalPadding")]
        public string HorizontalPadding { get; set; }

        [JsonProperty("verticalPadding")]
        public string VerticalPadding { get; set; }

        [JsonProperty("wrap")]
        public string Wrap { get; set; }

        [JsonProperty("anchorUrl")]
        public string AnchorUrl { get; set; }

        [JsonProperty("displayType")]
        public string DisplayType { get; set; }

        [JsonProperty("btnText")]
        public string BtnText { get; set; }

        [JsonProperty("btnTextActive")]
        public string BtnTextActive { get; set; }

        [JsonProperty("productAdded")]
        public string ProductAdded { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("tooMuchText")]
        public string TooMuchText { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("hideMessage")]
        public bool? HideMessage { get; set; }

        [JsonProperty("maxItemToCart")]
        public int? MaxItemToCart { get; set; }

        [JsonProperty("maxVisibleStock")]
        public int? MaxVisibleStock { get; set; }

        [JsonProperty("popupTextError")]
        public string PopupTextError { get; set; }

        [JsonProperty("popupTextMaxOrder")]
        public string PopupTextMaxOrder { get; set; }

        [JsonProperty("quantityMaxOrder")]
        public int? QuantityMaxOrder { get; set; }

        [JsonProperty("textAddToCartEmpty")]
        public string TextAddToCartEmpty { get; set; }

        [JsonProperty("textAddToCartFill")]
        public string TextAddToCartFill { get; set; }

        [JsonProperty("textAddToCartFillSecond")]
        public string TextAddToCartFillSecond { get; set; }

        [JsonProperty("textAddToCartPlus")]
        public string TextAddToCartPlus { get; set; }

        [JsonProperty("textLinkLitres")]
        public string TextLinkLitres { get; set; }

        [JsonProperty("textMaxOrder")]
        public string TextMaxOrder { get; set; }

        [JsonProperty("textOutsideDelivery")]
        public string TextOutsideDelivery { get; set; }

        [JsonProperty("textPreOrderActive")]
        public string TextPreOrderActive { get; set; }

        [JsonProperty("textPreOrderBefore")]
        public string TextPreOrderBefore { get; set; }

        [JsonProperty("textPreOrderFinished")]
        public string TextPreOrderFinished { get; set; }

        [JsonProperty("textPreOrderSubscribed")]
        public string TextPreOrderSubscribed { get; set; }

        [JsonProperty("textPremium")]
        public string TextPremium { get; set; }

        [JsonProperty("textPremiumAccess")]
        public string TextPremiumAccess { get; set; }

        [JsonProperty("textRegularDelivery")]
        public string TextRegularDelivery { get; set; }

        [JsonProperty("textSubscribe")]
        public string TextSubscribe { get; set; }

        [JsonProperty("textSubscribed")]
        public string TextSubscribed { get; set; }

        [JsonProperty("textSubscribedSecond")]
        public string TextSubscribedSecond { get; set; }

        [JsonProperty("textTwoButtons")]
        public string TextTwoButtons { get; set; }

        [JsonProperty("textUnavailable")]
        public string TextUnavailable { get; set; }

        [JsonProperty("checkOldSkuOffers")]
        public bool? CheckOldSkuOffers { get; set; }

        [JsonProperty("paramRegularDataDescription")]
        public string ParamRegularDataDescription { get; set; }

        [JsonProperty("paramRegularDataTitle")]
        public string ParamRegularDataTitle { get; set; }

        [JsonProperty("paramRegularInfoText")]
        public string ParamRegularInfoText { get; set; }

        [JsonProperty("textBannedArea")]
        public string TextBannedArea { get; set; }

        [JsonProperty("textPreOrderComingSoon")]
        public string TextPreOrderComingSoon { get; set; }

        [JsonProperty("textPreOrderComingStart")]
        public string TextPreOrderComingStart { get; set; }

        [JsonProperty("textPreOrderWillGoOnSale")]
        public string TextPreOrderWillGoOnSale { get; set; }

        [JsonProperty("textProductEnded")]
        public string TextProductEnded { get; set; }

        [JsonProperty("textProductEndedQuickly")]
        public string TextProductEndedQuickly { get; set; }

        [JsonProperty("textProductNotForSale")]
        public string TextProductNotForSale { get; set; }

        [JsonProperty("textProductPreRelease")]
        public string TextProductPreRelease { get; set; }

        [JsonProperty("holidaysNotificationLinkText")]
        public string HolidaysNotificationLinkText { get; set; }

        [JsonProperty("holidaysNotificationText")]
        public string HolidaysNotificationText { get; set; }

        [JsonProperty("multipleDeliveries")]
        public bool? MultipleDeliveries { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("basis")]
        public int? Basis { get; set; }

        [JsonProperty("defaultMediaCount")]
        public int? DefaultMediaCount { get; set; }

        [JsonProperty("returnText")]
        public string ReturnText { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("return-guarantee")]
        public bool? ReturnGuarantee { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("optionVariant")]
        public string OptionVariant { get; set; }

        [JsonProperty("popoverPlacement")]
        public string PopoverPlacement { get; set; }

        [JsonProperty("isCategoriesOpenByDefault")]
        public bool? IsCategoriesOpenByDefault { get; set; }

        [JsonProperty("premiumWithOzonCardLink")]
        public string PremiumWithOzonCardLink { get; set; }

        [JsonProperty("premiumWithoutOzonCardLink")]
        public string PremiumWithoutOzonCardLink { get; set; }

        [JsonProperty("level1")]
        public int? Level1 { get; set; }

        [JsonProperty("level1sg")]
        public int? Level1sg { get; set; }

        [JsonProperty("level2")]
        public int? Level2 { get; set; }

        [JsonProperty("level2sg")]
        public int? Level2sg { get; set; }

        [JsonProperty("bottom")]
        public int? Bottom { get; set; }

        [JsonProperty("top")]
        public int? Top { get; set; }

        [JsonProperty("overlapMagnifierDomSelector")]
        public string OverlapMagnifierDomSelector { get; set; }

        [JsonProperty("optionABTest")]
        public string OptionABTest { get; set; }

        [JsonProperty("sizeAsText")]
        public bool? SizeAsText { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("textHeader")]
        public string TextHeader { get; set; }

        [JsonProperty("columns")]
        public int? Columns { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("hintMaxLength")]
        public int? HintMaxLength { get; set; }

        [JsonProperty("isWidgetCharacteristicsOnPage")]
        public bool? IsWidgetCharacteristicsOnPage { get; set; }

        [JsonProperty("isWidgetDescriptionOnPage")]
        public bool? IsWidgetDescriptionOnPage { get; set; }

        [JsonProperty("linkToCharacteristics")]
        public string LinkToCharacteristics { get; set; }

        [JsonProperty("linkToCharacteristicsButtonText")]
        public string LinkToCharacteristicsButtonText { get; set; }

        [JsonProperty("linkToDescription")]
        public string LinkToDescription { get; set; }

        [JsonProperty("linkToDescriptionButtonText")]
        public string LinkToDescriptionButtonText { get; set; }

        [JsonProperty("linkToExternalText")]
        public string LinkToExternalText { get; set; }

        [JsonProperty("paramsLinkTarget")]
        public string ParamsLinkTarget { get; set; }

        [JsonProperty("thresholdLength")]
        public int? ThresholdLength { get; set; }

        [JsonProperty("topList")]
        public bool? TopList { get; set; }

        [JsonProperty("viewLine")]
        public string ViewLine { get; set; }

        [JsonProperty("visibleCount")]
        public int? VisibleCount { get; set; }

        [JsonProperty("showTrustFactor")]
        public bool? ShowTrustFactor { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}