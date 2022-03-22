<template>
  <div id="categoryGoods">
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
import { mapGetters } from 'vuex'
import SkuContainer from '@/components/common/SkuContainer'

export default {
  name: 'CategoryGoods',

  components: {
    SkuContainer,
  },

  computed: {
    ...mapGetters({
      skuLine: 'category/skuLine',
      skuLineLR: 'category/skuLineLR',
      skuShelfGoods: 'category/skuShelfGoods',
    }),
    skuContainers() {
      return [...this.skuLine, ...this.skuLineLR, ...this.skuShelfGoods]
    },
  },
}
</script>

<style scoped>

</style>
