<template>
  <div id="price">
    <strong class="actual-price">
      {{ currentPrice }} <sub v-if="originalPrice" class="original-price">{{ originalPrice }}</sub>
    </strong>
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
      return this.item.rightState
        ? _find(this.item.rightState, (state) => state.id === 'atom' && state.atom.type === 'price')?.atom?.price
          : _find(this.item.mainState, (state) => state.id === 'atom' && state.atom.type === 'price')?.atom?.price
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
.actual-price {
  font-size: 24px;
  color: rgb(249, 17, 85);
}
.original-price {
  color: black;
}
.original-price::after {
  height: 3px;
  content: "";
  display: block;
  left: 0;
  position: absolute;
  top: calc(50% - 1px);
  transform: rotate(-2deg);
  background-color: red;
  width: 100%;
}
</style>
