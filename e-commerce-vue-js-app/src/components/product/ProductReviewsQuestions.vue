<template>
  <div id="productReviewsQuestions">
    <h2>Отзывы и вопросы о товаре <sup>{{ reviewsCount }}</sup></h2>
    <a-tabs default-active-key="reviewsTab">
      <a-tab-pane key="reviewsTab" tab="Отзывы о товаре">
        <ReviewsTab
          :product="product"
          :asyncData="asyncData"
          :productUrl="productUrl"
        />
      </a-tab-pane>
      <a-tab-pane key="questionsTab" tab="Вопросы и ответы о товаре">

      </a-tab-pane>
    </a-tabs>
  </div>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'
import ReviewsTab from '@/components/product/tabs/ReviewsTab'

export default {
  name: 'ProductReviewsQuestions',

  components: {
    ReviewsTab,
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

  computed: {
    widgets() {
      return this.product?.widgetStates
    },
    reviewProductScore() {
      return getWidget(this.widgets, 'webReviewProductScore')
    },
    reviewsCount() {
      return this.reviewProductScore?.reviewsCount || 0
    },
  },
}
</script>

<style scoped>

</style>
