<template>
  <div id="productBrand">
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
            <span>Бренд:</span>
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
  name: 'ProductBrand',

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
    brand() {
      return getWidget(this.widgets, 'webBrand')
    },
    name() {
      return this.brand?.name || ''
    },
    image() {
      return this.brand?.coverImage || ''
    },
  },
}
</script>

<style scoped>
#productBrand img {
  max-width: 60px;
  max-width: 60px;
  object-fit: contain;
}
</style>
