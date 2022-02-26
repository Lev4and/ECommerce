<template>
  <div id="colorVariants">
    <template v-for="(colorVariant, i) in colorVariantsItems">
      <template v-for="(color, j) in colorVariant.hex">
        <a-tag
          :key="`${i} - ${j}`"
          :class="'tag'"
        >
          <a-badge
            :color="color"
            :class="'color-variants-item'"
          />
        </a-tag>
      </template>
    </template>
    <span v-if="colorVariantsText">{{ colorVariantsText }}</span>
  </div>
</template>

<script>
import { find as _find } from 'lodash'

export default {
  name: 'ColorVariants',

  props: {
    item: {
      type: Object,
      required: true,
    },
  },

  computed: {
    colorVariants() {
      return _find(this.item.mainState, (state) => state.id === 'atom' && state.atom.type === 'colorVariants')
    },
    colorVariantsText() {
      return this.colorVariants?.atom?.colorVariants?.text || ''
    },
    colorVariantsItems() {
      return this.colorVariants?.atom?.colorVariants?.items || []
    },
  },
}
</script>

<style>
#colorVariants {
  display: flex;
  flex-direction: row;
}
#colorVariants .tag .color-variants-item .ant-badge-status-dot {
  width: 12px !important;
  height: 12px !important;
}
#colorVariants .tag .color-variants-item .ant-badge-status-text {
  display: none;
}
</style>
