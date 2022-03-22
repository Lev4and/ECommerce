<template>
  <div id="skuContainer">
    <h2>{{ header }}</h2>
    <div class="sku-container">
      <a-row :gutter="[8,16]">
        <template v-for="product in products">
          <a-col :key="product.skuId" :sm="12" :md="8" :lg="6" :xl="4" :xxl="4">
            <SkuContainerItem :product="product" />
          </a-col>
        </template>
      </a-row>
    </div>
  </div>
</template>

<script>
import SkuContainerItem from '@/components/common/skuContainer/SkuContainerItem'

export default {
  name: 'SkuContainer',

  components: {
    SkuContainerItem,
  },

  props: {
    sku: {
      type: Object,
      default: null,
      required: false,
    },
  },

  computed: {
    header() {
      return this.sku?.header?.title || ''
    },
    products() {
      return this.sku?.productContainer?.products || []
    },
  },
}
</script>

<style scoped>

</style>
