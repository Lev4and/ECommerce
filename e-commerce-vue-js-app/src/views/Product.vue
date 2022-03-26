<template>
  <div id="product">
    <a-spin
      :spinning="!isLoading"
    >
      <a-icon
        slot="indicator"
        type="loading"
        style="font-size: 96px"
        spin
      />
      <a-row :gutter="[0,48]">
        <a-col :span="24">
          <ProductBreadcrumb :product="product" />
        </a-col>
        <a-col :span="24">
          <ProductHeader :product="product" />
        </a-col>
        <a-col :span="24">
          <a-row :gutter="[0,48]">
            <a-col :span="10">
              <ProductGallery :product="product" />
            </a-col>
            <a-col :span="14">
              <a-row :gutter="[0,48]">
                <a-col :span="16">
                  <a-row :gutter="[16,0]">
                    <a-col :span="24">
                      <ProductAspects :product="product" />
                    </a-col>
                    <a-col :span="24">
                      <ProductMainCharacteristics :product="product" />
                    </a-col>
                  </a-row>
                </a-col>
                <a-col :span="8">
                  <a-row :gutter="[0,16]">
                    <a-col :span="24">
                      <ProductPrice :product="product" />
                    </a-col>
                    <a-col :span="24">
                      <a-button
                        type="primary"
                        style="width: 100%; font-size: 16px; height: 40px;"
                      >
                        <span style="padding: 8px;">
                          Добавить в корзину
                        </span>
                      </a-button>
                    </a-col>
                  </a-row>
                </a-col>
              </a-row>
            </a-col>
          </a-row>
        </a-col>
        <a-col :span="24">
          <ProductBrand :product="product" />
        </a-col>
        <a-col :span="24">
          <ProductSeller :product="product" />
        </a-col>
        <a-col :span="24">
          <ProductBundleDetails :product="characteristics" />
        </a-col>
        <a-col :span="24">
          <ProductGoods :product="characteristics" />
        </a-col>
        <a-col :span="24">
          <ProductDescription :product="characteristics" />
        </a-col>
        <a-col :span="24">
          <ProductCharacteristics :product="characteristics" />
        </a-col>
        <a-col :span="24">
          <ProductTagsList :product="characteristics" />
        </a-col>
      </a-row>
    </a-spin>
  </div>
</template>

<script>
import API from '@/api'
import { getWidget } from '@/services/utils/widgetsUtils'
import ProductBreadcrumb from '@/components/product/ProductBreadcrumb'
import ProductHeader from '@/components/product/ProductHeader'
import ProductGallery from '@/components/product/ProductGallery'
import ProductAspects from '@/components/product/ProductAspects'
import ProductMainCharacteristics from '@/components/product/ProductMainCharacteristics'
import ProductPrice from '@/components/product/ProductPrice'
import ProductBrand from '@/components/product/ProductBrand'
import ProductSeller from '@/components/product/ProductSeller'
import ProductBundleDetails from '@/components/product/ProductBundleDetails'
import ProductGoods from '@/components/product/ProductGoods'
import ProductDescription from '@/components/product/ProductDescription'
import ProductCharacteristics from '@/components/product/ProductCharacteristics'
import ProductTagsList from '@/components/product/ProductTagsList'

export default {
  name: 'Product',

  components: {
    ProductBreadcrumb,
    ProductHeader,
    ProductGallery,
    ProductAspects,
    ProductMainCharacteristics,
    ProductPrice,
    ProductBrand,
    ProductSeller,
    ProductBundleDetails,
    ProductGoods,
    ProductDescription,
    ProductCharacteristics,
    ProductTagsList,
  },

  data: () => ({
    isLoading: false,
    characteristics: null,
    reviews: null,
    product: null,
  }),

  computed: {
    productUrl() {
      return this.$route.query.url
    },
    characteristicsUrl() {
      return getWidget(this.product?.widgetStates, 'paginator')?.nextPage
    },
    reviewsUrl() {
      return getWidget(this.characteristics?.widgetStates, 'paginator')?.nextPage
    },
  },

  watch: {
    productUrl: {
      handler() {
        this.loadProduct()
      },
      deep: true,
      immediate: true,
    },
  },

  methods: {
    async loadProduct() {
      this.isLoading = false
      this.product = await API.product.getProduct(this.productUrl)
      this.characteristics = await API.product.getCharacteristics(this.characteristicsUrl)
      this.reviews = await API.product.getReviews(this.reviewsUrl)
      this.isLoading = true
    },
  },
}
</script>

<style>
#product .ant-spin.ant-spin-spinning {
  top: 50% !important;
  left: 50% !important;
  z-index: 4 !important;
  width: auto !important;
  height: auto !important;
  position: fixed !important;
  margin-top: -48px !important;
  margin-left: -48px !important;
}
</style>

<style scoped>
#product {
  min-height: 100vh;
}
</style>
