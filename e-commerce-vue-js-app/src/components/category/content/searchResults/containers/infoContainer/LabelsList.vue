<template>
  <div id="labelsList">
    <template v-for="label in labels">
      <a-tag
        :key="label.atom.textAtom.text"
        :class="'tag'"
      >
        {{ label.atom.textAtom.text }}
      </a-tag>
    </template>
  </div>
</template>

<script>
import { filter as _filter } from 'lodash'

export default {
  name: 'LabelsList',

  props: {
    item: {
      type: Object,
      required: true,
    },
  },

  computed: {
    labels() {
      return _filter(this.item.mainState, (state) => state.id === 'label') || []
    },
  },
}
</script>
