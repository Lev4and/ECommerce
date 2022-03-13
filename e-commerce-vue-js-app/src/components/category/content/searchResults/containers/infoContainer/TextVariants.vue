<template>
  <div id="textVariants">
    <template v-for="(textVariantsItem, index) in textVariantsItems">
      <a-tag
        :key="index"
        :class="'tag'"
      >
        {{ textVariantsItem }}
      </a-tag>
    </template>
    <span v-if="textVariantsText">{{ textVariantsText }}</span>
  </div>
</template>

<script>
import { find as _find } from 'lodash'

export default {
  name: 'TextVariants',

  props: {
    item: {
      type: Object,
      required: true,
    },
  },

  computed: {
    textVariants() {
      return _find(this.item.mainState, (state) => state.id === 'atom' && state.atom.type === 'textVariants')
    },
    textVariantsText() {
      return this.textVariants?.atom?.textVariants?.text || ''
    },
    textVariantsItems() {
      return this.textVariants?.atom?.textVariants?.items || []
    },
  },
}
</script>

<style>
#textVariants .tag {
  font-size: 16px;
  margin: 0 8px 8px 0;
}
</style>
