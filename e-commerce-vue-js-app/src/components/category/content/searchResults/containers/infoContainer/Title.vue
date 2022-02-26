<template>
  <strong v-html="title" />
</template>

<script>
import { find as _find } from 'lodash'

export default {
  name: 'Title',

  props: {
    item: {
      type: Object,
      required: true,
    },
  },

  computed: {
    title() {
      return _find(this.item.mainState, (state) => state.id === 'name')?.atom?.textAtom?.text || 'Undefined'
    },
  },
}
</script>
