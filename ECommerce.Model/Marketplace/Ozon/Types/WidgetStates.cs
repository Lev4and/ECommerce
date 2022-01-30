using ECommerce.Model.JsonConverters;
using Newtonsoft.Json;

namespace ECommerce.Model.Marketplace.Ozon.Types
{
    public class WidgetStates
    {
        [JsonProperty("bannerCarousel-798374-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<BannerCarousel>))]
        public BannerCarousel BannerCarousel { get; set; }

        [JsonProperty("catalogMenu-390814-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<CatalogMenu>))]
        public CatalogMenu CatalogMenu { get; set; }

        [JsonProperty("catalogResultsBreadCrumbs-207531-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<CatalogResultsBreadCrumbs>))]
        public CatalogResultsBreadCrumbs CatalogResultsBreadCrumbs { get; set; }

        [JsonProperty("catalogResultsHeader-207532-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<CatalogResultsHeader>))]
        public CatalogResultsHeader CatalogResultsHeader { get; set; }

        [JsonProperty("container-207453-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Container>))]
        public Container Container { get; set; }

        [JsonProperty("favoriteCounter-810546-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<FavoriteCounter>))]
        public FavoriteCounter FavoriteCounter { get; set; }

        [JsonProperty("footer-207454-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Footer>))]
        public Footer Footer { get; set; }

        [JsonProperty("header-215156-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Header>))]
        public Header Header { get; set; }

        [JsonProperty("headerIcon-825754-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<HeaderIcon>))]
        public HeaderIcon HeaderIcon { get; set; }

        [JsonProperty("horizontalMenu-390308-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<HorizontalMenu>))]
        public HorizontalMenu HorizontalMenu { get; set; }

        [JsonProperty("megaPaginator-252190-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<MegaPaginator>))]
        public MegaPaginator MegaPaginator { get; set; }

        [JsonProperty("orderInfo-215463-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<OrderInfo>))]
        public OrderInfo OrderInfo { get; set; }

        [JsonProperty("orderTracking-215462-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<OrderTracking>))]
        public OrderTracking OrderTracking { get; set; }

        [JsonProperty("profileMenuAnonymous-313845-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<ProfileMenuAnonymous>))]
        public ProfileMenuAnonymous ProfileMenuAnonymous { get; set; }

        [JsonProperty("searchBarDesktop-215158-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<SearchBarDesktop>))]
        public SearchBarDesktop SearchBarDesktop { get; set; }

        [JsonProperty("searchContextPopup-215157-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<SearchContextPopup>))]
        public SearchContextPopup SearchContextPopup { get; set; }

        [JsonProperty("searchResultsFilters-207442-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<SearchResultsFilters>))]
        public SearchResultsFilters SearchResultsFilters { get; set; }

        [JsonProperty("searchResultsFiltersActive-207446-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<SearchResultsFiltersActive>))]
        public SearchResultsFiltersActive SearchResultsFiltersActive { get; set; }

        [JsonProperty("searchResultsSort-207447-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<SearchResultsSort>))]
        public SearchResultsSort SearchResultsSort { get; set; }

        [JsonProperty("addToFavorite-347772-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<AddToFavorite>))]
        public AddToFavorite AddToFavorite1 { get; set; }

        [JsonProperty("addToFavorite-726426-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<AddToFavorite>))]
        public AddToFavorite AddToFavorite2 { get; set; }

        [JsonProperty("breadCrumbsPdp-347757-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<BreadCrumbsPdp>))]
        public BreadCrumbsPdp BreadCrumbsPdp { get; set; }

        [JsonProperty("column-347761-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Column>))]
        public Column Column1 { get; set; }

        [JsonProperty("column-347765-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Column>))]
        public Column Column2 { get; set; }

        [JsonProperty("column-347779-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Column>))]
        public Column Column3 { get; set; }

        [JsonProperty("column-347787-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Column>))]
        public Column Column4 { get; set; }

        [JsonProperty("column-702922-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Column>))]
        public Column Column5 { get; set; }

        [JsonProperty("customHtml-1079512-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<CustomHtml>))]
        public CustomHtml CustomHtml1 { get; set; }

        [JsonProperty("customHtml-347935-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<CustomHtml>))]
        public CustomHtml CustomHtml2 { get; set; }

        [JsonProperty("customHtml-403477-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<CustomHtml>))]
        public CustomHtml CustomHtml3 { get; set; }

        [JsonProperty("directDiscountCoupon-836054-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<DirectDiscountCoupon>))]
        public DirectDiscountCoupon DirectDiscountCoupon { get; set; }

        [JsonProperty("paginator-658722-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Paginator>))]
        public Paginator Paginator { get; set; }

        [JsonProperty("paginator-318686-pdpPage2column-2")]
        [JsonConverter(typeof(ToObjectJsonConverter<Paginator>))]
        public Paginator PaginatorPdpPage2Column { get; set; }

        [JsonProperty("pdpPriceSubscribe-835916-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<PdpPriceSubscribe>))]
        public PdpPriceSubscribe PdpPriceSubscribe { get; set; }

        [JsonProperty("pickpointsMap-836041-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<PickpointsMap>))]
        public PickpointsMap PickpointsMap1 { get; set; }

        [JsonProperty("pickpointsMap-836043-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<PickpointsMap>))]
        public PickpointsMap PickpointsMap2 { get; set; }

        [JsonProperty("row-347762-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Row>))]
        public Row Row1 { get; set; }

        [JsonProperty("row-347780-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Row>))]
        public Row Row2 { get; set; }

        [JsonProperty("row-347858-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Row>))]
        public Row Row3 { get; set; }

        [JsonProperty("row-702923-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Row>))]
        public Row Row4 { get; set; }

        [JsonProperty("separator-347760-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Separator>))]
        public Separator Separator1 { get; set; }

        [JsonProperty("separator-347777-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Separator>))]
        public Separator Separator2 { get; set; }

        [JsonProperty("separator-347781-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Separator>))]
        public Separator Separator3 { get; set; }

        [JsonProperty("separator-347867-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Separator>))]
        public Separator Separator4 { get; set; }

        [JsonProperty("separator-347966-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Separator>))]
        public Separator Separator5 { get; set; }

        [JsonProperty("separator-709024-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Separator>))]
        public Separator Separator6 { get; set; }

        [JsonProperty("separator-909632-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<Separator>))]
        public Separator Separator7 { get; set; }

        [JsonProperty("stickyContainer-411269-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<StickyContainer>))]
        public StickyContainer StickyContainer { get; set; }

        [JsonProperty("topBar-215461-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<TopBar>))]
        public TopBar TopBar { get; set; }

        [JsonProperty("webAddToCart-839363-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebAddToCart>))]
        public WebAddToCart WebAddToCart1 { get; set; }

        [JsonProperty("webAddToCart-910459-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebAddToCart>))]
        public WebAddToCart WebAddToCart2 { get; set; }

        [JsonProperty("webAddToCompare-939214-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebAddToCompare>))]
        public WebAddToCompare WebAddToCompare1 { get; set; }

        [JsonProperty("webAddToCompare-939216-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebAddToCompare>))]
        public WebAddToCompare WebAddToCompare2 { get; set; }

        [JsonProperty("webAspects-418255-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebAspects>))]
        public WebAspects WebAspects { get; set; }

        [JsonProperty("webBestSeller-835913-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebBestSeller>))]
        public WebBestSeller WebBestSeller { get; set; }

        [JsonProperty("webBrand-1033271-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebBrand>))]
        public WebBrand WebBrand { get; set; }

        [JsonProperty("webCharacteristics-545721-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebCharacteristics>))]
        public WebCharacteristics WebCharacteristics { get; set; }

        [JsonProperty("webCharacteristics-939965-pdpPage2column-2")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebCharacteristics>))]
        public WebCharacteristics WebCharacteristicsPdpPage2Column { get; set; }

        [JsonProperty("webCurrentSeller-735774-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebCurrentSeller>))]
        public WebCurrentSeller WebCurrentSeller { get; set; }

        [JsonProperty("webDelivery-836042-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebDelivery>))]
        public WebDelivery WebDelivery1 { get; set; }

        [JsonProperty("webDelivery-836044-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebDelivery>))]
        public WebDelivery WebDelivery2 { get; set; }

        [JsonProperty("webDeliveryRating-367892-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebDeliveryRating>))]
        public WebDeliveryRating WebDeliveryRating { get; set; }

        [JsonProperty("webDescription-620241-pdpPage2column-2")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebDescription>))]
        public WebDescription WebDescription { get; set; }

        [JsonProperty("webDetailSKU-909751-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebDetail>))]
        public WebDetail WebDetail { get; set; }

        [JsonProperty("webGallery-393698-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebGallery>))]
        public WebGallery WebGallery { get; set; }

        [JsonProperty("webGiftBuyButton-373749-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebGiftBuyButton>))]
        public WebGiftBuyButton WebGiftBuyButton { get; set; }

        [JsonProperty("webListPhotos-823113-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebListPhotos>))]
        public WebListPhotos WebListPhotos { get; set; }

        [JsonProperty("webMarketingLabels-713664-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebMarketingLabels>))]
        public WebMarketingLabels WebMarketingLabels { get; set; }

        [JsonProperty("webMarketingMarks-347766-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebMarketingMarks>))]
        public WebMarketingMarks WebMarketingMarks { get; set; }

        [JsonProperty("webOneClickButton-674298-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebOneClickButton>))]
        public WebOneClickButton WebOneClickButton { get; set; }

        [JsonProperty("webPremiumPointsInfo-929580-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebPremiumPointsInfo>))]
        public WebPremiumPointsInfo WebPremiumPointsInfo { get; set; }

        [JsonProperty("webPrice-952422-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebPrice>))]
        public WebPrice WebPrice { get; set; }

        [JsonProperty("webProductHeading-943796-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebProductHeading>))]
        public WebProductHeading WebProductHeading { get; set; }

        [JsonProperty("webProductMainWidget-347746-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebProductMainWidget>))]
        public WebProductMainWidget WebProductMainWidget { get; set; }

        [JsonProperty("webQuestionCount-484493-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebQuestionCount>))]
        public WebQuestionCount WebQuestionCount1 { get; set; }

        [JsonProperty("webQuestionCount-726418-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebQuestionCount>))]
        public WebQuestionCount WebQuestionCount2 { get; set; }

        [JsonProperty("webReportInaccuracy-433078-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebReportInaccuracy>))]
        public WebReportInaccuracy WebReportInaccuracy { get; set; }

        [JsonProperty("webReviewGallery-823114-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebReviewGallery>))]
        public WebReviewGallery WebReviewGallery { get; set; }

        [JsonProperty("webReviewProductScore-484492-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebReviewProductScore>))]
        public WebReviewProductScore WebReviewProductScore1 { get; set; }

        [JsonProperty("webReviewProductScore-726417-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebReviewProductScore>))]
        public WebReviewProductScore WebReviewProductScore2 { get; set; }

        [JsonProperty("webSale-849839-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebSale>))]
        public WebSale WebSale { get; set; }

        [JsonProperty("webScores-1025970-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebScores>))]
        public WebScores WebScores { get; set; }

        [JsonProperty("webSellerCondition-367999-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebSellerCondition>))]
        public WebSellerCondition WebSellerCondition { get; set; }

        [JsonProperty("webSharingButton-844950-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebSharingButton>))]
        public WebSharingButton WebSharingButton { get; set; }

        [JsonProperty("webStickyProducts-726428-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebStickyProducts>))]
        public WebStickyProducts WebStickyProducts { get; set; }

        [JsonProperty("webTrustFactors-347944-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebTrustFactors>))]
        public WebTrustFactors WebTrustFactors { get; set; }

        [JsonProperty("webVideosCount-972260-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<WebVideosCount>))]
        public WebVideosCount WebVideosCount { get; set; }


        [JsonProperty("searchResultsV2-252189-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<SearchResults>))]
        public SearchResults SearchResults { get; set; }

        [JsonProperty("skuAdvSearchShelf-759098-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<SkuAdvSearchShelf>))]
        public SkuAdvSearchShelf SkuAdvSearchShelf { get; set; }

        [JsonProperty("skuLine-317524-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<SkuLine>))]
        public SkuLine SkuLine { get; set; }

        [JsonProperty("tagList-400548-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<TagList>))]
        public TagList TagList1 { get; set; }

        [JsonProperty("tagList-518966-default-1")]
        [JsonConverter(typeof(ToObjectJsonConverter<TagList>))]
        public TagList TagList2 { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}