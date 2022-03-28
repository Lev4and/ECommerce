<template>
  <div id="reviewsTab">
    <a-row :gutter="[48,0]">
      <a-col :span="16">
        <Reviews
          :product="product"
          :asyncData="asyncData"
          :productUrl="productUrl"
        />
      </a-col>
      <a-col :span="8">
        <ReviewsStatistic :product="product" />
      </a-col>
    </a-row>
  </div>
</template>

<script>
import Reviews from '@/components/product/tabs/reviewsTab/Reviews'
import ReviewsStatistic from '@/components/product/tabs/reviewsTab/ReviewsStatistic'

export default {
  name: 'ReviewsTab',

  components: {
    Reviews,
    ReviewsStatistic,
  },

  props: {
    product: {
      type: Object,
      default: null,
      required: false,
    },
    asyncData: {
      default: '',
      type: String,
      required: false,
    },
    productUrl: {
      default: '',
      type: String,
      required: false,
    },
  },
}
</script>

<style scoped>

</style>
