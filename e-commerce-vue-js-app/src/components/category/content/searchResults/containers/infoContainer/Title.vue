<!-- eslint-disable vue/no-v-html -->
<template>
  <router-link :to="{ name: 'Product', query: { url: link } }">
    <strong v-html="title" />
  </router-link>
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
    link() {
      return this.item.action.link
    },
  },
}
</script>
