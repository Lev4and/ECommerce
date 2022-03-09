<template>
  <div id="productHeader">
    <a-row>
      <a-col :span="24">
        <h1 class="title">
          {{ title }}
        </h1>
      </a-col>
      <a-col :span="24">
        <a-row
          type="flex"
          justify="space-between"
        >
          <a-col :span="16">
            <a-row
              type="flex"
              align="middle"
              :gutter="[16,0]"
            >
              <a-col>
                <a-rate
                  :disabled="true"
                  :value="totalScore"
                />
                <span class="ant-rate-text">({{ totalScore.toFixed(2) }}) {{ reviewsCount }}</span>
              </a-col>
              <a-col>
                <a-icon type="message" /> {{ questionCountText }}
              </a-col>
              <a-col>
                <a-icon type="heart" /> В избранное
              </a-col>
              <a-col>
                <a-icon type="plus" /> Добавить к сравнению
              </a-col>
              <a-col>
                <a-icon type="share-alt" /> Поделиться
              </a-col>
            </a-row>
          </a-col>
          <a-col :span="8">
            <a-row
              type="flex"
              align="middle"
              justify="end"
            >
              <a-col>
                <div>Код: {{ id }}</div>
              </a-col>
            </a-row>
          </a-col>
        </a-row>
      </a-col>
    </a-row>
    <a-divider type="horizontal" />
  </div>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'ProductHeader',

  props: {
    product: {
      type: Object,
      default: null,
      required: false,
    },
  },

  computed: {
    widgets() {
      return this.product?.widgetStates
    },
    sale() {
      return getWidget(this.widgets, 'webSale')
    },
    reviewProductScore() {
      return getWidget(this.widgets, 'webReviewProductScore')
    },
    questionCount() {
      return getWidget(this.widgets, 'webQuestionCount')
    },
    questionCountText() {
      return this.questionCount?.text || '0 вопросов'
    },
    totalScore() {
      return this.reviewProductScore?.totalScore || 0
    },
    reviewsCount() {
      return this.reviewProductScore?.reviewsCount || 0
    },
    title() {
      return this.sale?.cellTrackingInfo?.product?.title || ''
    },
    id() {
      return this.sale?.cellTrackingInfo?.product?.id || ''
    },
  },
}
</script>

<style>
#productHeader div.ant-divider.ant-divider-horizontal {
  margin: 12px 0;
}
</style>

<style scoped>

</style>
