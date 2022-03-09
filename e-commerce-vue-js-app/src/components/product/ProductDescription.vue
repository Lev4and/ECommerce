<!-- eslint-disable vue/no-v-html -->
<template>
  <div id="productDescription">
    <h2>Описание</h2>
    <div v-html="description" />
  </div>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'ProductDescription',

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
    description() {
      return getWidget(this.widgets, 'webDescription')?.richAnnotation || ''
    },
  },
}
</script>

<style scoped>

</style>
