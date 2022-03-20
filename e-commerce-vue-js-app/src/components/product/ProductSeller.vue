<template>
  <div id="productSeller">
    <a-row
      type="flex"
      align="middle"
      justify="start"
    >
      <a-col flex="80px">
        <img :src="image">
      </a-col>
      <a-col>
        <a-row
          type="flex"
          align="middle"
          :gutter="[0,12]"
        >
          <a-col :span="24">
            <span>Продавец:</span>
          </a-col>
          <a-col :span="24">
            <strong>{{ name }}</strong>
          </a-col>
        </a-row>
      </a-col>
    </a-row>
  </div>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'ProductSeller',

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
    seller() {
      return getWidget(this.widgets, 'webCurrentSeller')
    },
    name() {
      return this.seller?.name || ''
    },
    image() {
      return this.seller?.logoImageUrl || ''
    },
  },
}
</script>

<style scoped>
#productSeller img {
  max-width: 60px;
  max-width: 60px;
  object-fit: contain;
}
</style>
