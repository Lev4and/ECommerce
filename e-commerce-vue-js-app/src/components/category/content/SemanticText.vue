<!-- eslint-disable vue/no-v-html -->
<template>
  <div
    id="semanticText"
    v-html="semanticText"
  />
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'SemanticText',

  props: {
    category: {
      type: Object,
      default: null,
      required: false,
    },
  },

  computed: {
    widgets() {
      return this.category?.widgetStates
    },
    semanticText() {
      return getWidget(this.widgets, 'semanticText')?.semantic_text || ''
    },
  },
}
</script>

<style scoped>

</style>
