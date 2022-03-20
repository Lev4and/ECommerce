<template>
  <div id="productGoods">
    <template v-for="(skuContainer, i) in skuContainers">
      <a-col
        :key="i"
        :span="24"
      >
        <SkuContainer :sku="skuContainer" />
      </a-col>
    </template>
  </div>
</template>

<script>
import { getWidgets } from '@/services/utils/widgetsUtils'
import SkuContainer from '@/components/common/SkuContainer'

export default {
  name: 'ProductGoods',

  components: {
    SkuContainer,
  },

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
    skuContainers() {
      return getWidgets(this.widgets, 'skuShelfGoods') || []
    },
  },
}
</script>

<style scoped>

</style>
