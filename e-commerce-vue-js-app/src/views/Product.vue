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
      <a-row>
        <a-col :span="24">
          <ProductBreadcrumb :product="product" />
        </a-col>
        <a-col :span="24">
          <ProductHeader :product="product" />
        </a-col>
        <a-col :span="24">
          <ProductDescription :product="reviews" />
        </a-col>
        <a-col :span="24">
          <ProductCharacteristics :product="reviews" />
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
import ProductDescription from '@/components/product/ProductDescription'
import ProductCharacteristics from '@/components/product/ProductCharacteristics'

export default {
  name: 'Product',

  components: {
    ProductBreadcrumb,
    ProductHeader,
    ProductDescription,
    ProductCharacteristics,
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

  mounted() {
    this.loadProduct()
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
