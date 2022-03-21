<template>
  <div
    v-if="discount"
    class="discount-container"
  >
    <span>{{ discount }}</span>
  </div>
</template>

<script>
import { find as _find } from 'lodash'

export default {
  name: 'Discount',

  props: {
    item: {
      type: Object,
      required: true,
    },
  },

  computed: {
    discount() {
      return _find(this.item.rightState, (state) => state.id === 'badge' && state.atom.type === 'badge' &&
        state.atom.badge.theme === 'STYLE_TYPE_DISCOUNT')?.atom?.badge?.text || ''
    },
  },
}
</script>

<style scoped>
.discount-container {
  align-items: center;
  border-radius: 12px;
  box-sizing: border-box;
  display: inline-flex;
  justify-content: center;
  overflow: hidden;
  font-size: 14px;
  height: 24px;
  line-height: 18px;
  padding: 3px 10px;
  flex-shrink: 0;
  font-weight: 700;
  color: rgb(255, 255, 255);
  background-color: rgb(249, 17, 85);
  width: fit-content;
}
.discount-container span {
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
  color: rgb(255, 255, 255);
  font-weight: 700;
  font-size: 16px;
}
</style>
