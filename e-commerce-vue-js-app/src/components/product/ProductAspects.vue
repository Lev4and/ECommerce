<template>
  <div id="productAspects">
    <template v-for="(aspect, i) in aspects">
      <AspectType
        :key="i"
        :aspect="aspect"
      />
    </template>
  </div>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'
import AspectType from '@/components/product/AspectType'

export default {
  name: 'ProductAspects',

  components: {
    AspectType,
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
    aspects() {
      return getWidget(this.widgets, 'webAspects')?.aspects || []
    },
  },
}
</script>

<style scoped>

</style>
