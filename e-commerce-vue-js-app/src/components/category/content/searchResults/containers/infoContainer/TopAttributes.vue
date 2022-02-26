<!-- eslint-disable vue/no-v-html -->
<template>
  <div v-html="topAttributes" />
</template>

<script>
import { find as _find } from 'lodash'

export default {
  name: 'TopAttributes',

  props: {
    item: {
      type: Object,
      required: true,
    },
  },

  computed: {
    topAttributes() {
      return _find(this.item.mainState, (state) => state.id === 'topAttributes')?.atom?.textAtom?.text || ''
    },
  },
}
</script>
