<template>
  <div id="colorVariants">
    <template v-for="(colorVariant, i) in colorVariantsItems">
      <a-tag
        :key="i"
        :class="'tag'"
      >
        <ColorfulBadge
          :colors="colorVariant.hex"
          :className="'color-variants-item'"
        />
      </a-tag>
    </template>
    <span v-if="colorVariantsText">{{ colorVariantsText }}</span>
  </div>
</template>

<script>
import { find as _find } from 'lodash'
import ColorfulBadge from '@/components/common/ColorfulBadge'

export default {
  name: 'ColorVariants',

  components: {
    ColorfulBadge,
  },

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
  flex-wrap: wrap;
  flex-direction: row;
}
#colorVariants .tag {
  margin: 0 8px 8px 0;
}
#colorVariants .tag .color-variants-item .ant-badge-status-dot {
  width: 16px !important;
  height: 16px !important;
  border: 1px black solid;
}
#colorVariants .tag .color-variants-item .ant-badge-status-text {
  display: none;
}
</style>
