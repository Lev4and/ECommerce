<template>
  <div class="current-original-price">
    <div class="current-price">
      <span style="color: #f5222d">{{ currentPrice }}</span>
    </div>
    <div
      v-if="originalPrice"
      class="original-price"
    >
      <span>{{ originalPrice }}</span>
    </div>
  </div>
</template>

<script>
import { find as _find } from 'lodash'

export default {
  name: 'Price',

  props: {
    item: {
      type: Object,
      required: true,
    },
  },

  computed: {
    price() {
      return _find(this.item.rightState, (state) => state.id === 'atom' && state.atom.type === 'price')?.atom?.price
    },
    currentPrice() {
      return this.price?.price || ''
    },
    originalPrice() {
      return this.price?.originalPrice || ''
    },
  },
}
</script>

<style scoped>
.current-original-price {
  align-items: center;
  display: flex;
  flex-wrap: wrap;
}
.current-original-price div.original-price {
  font-size: 14px;
  line-height: 14px;
  position: relative;
  color: rgb(0, 26, 52);
}
.current-original-price div.current-price {
  color: rgb(249, 17, 85);
  font-size: 20px;
  font-weight: 700;
  line-height: 26px;
  margin: 0 4px 0 0;
}
</style>
