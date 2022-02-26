<template>
  <div id="rating">
    <a-rate
      :disabled="true"
      :default-value="ratingValue"
    />
    <span class="ant-rate-text">({{ ratingValue.toFixed(2) }}) {{ ratingCount }}</span>
  </div>
</template>

<script>
import { find as _find } from 'lodash'

export default {
  name: 'Rating',

  props: {
    item: {
      type: Object,
      required: true,
    },
  },

  computed: {
    rating() {
      return _find(this.item.mainState, (state) => state.id === 'atom' && state.atom.type === 'rating')
    },
    ratingValue() {
      return this.rating?.atom?.rating?.rating || 0
    },
    ratingCount() {
      return this.rating?.atom?.rating?.count || '0 отзывов'
    },
  },
}
</script>
