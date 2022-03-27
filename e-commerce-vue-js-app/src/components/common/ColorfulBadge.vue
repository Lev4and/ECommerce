<template>
  <span
    :class="['ant-badge', 'ant-badge-status', 'ant-badge-not-a-wrapper', className]"
  >
    <span
      class="ant-badge-status-dot"
      :style="`background: linear-gradient(90deg, ${linearGradient});`"
    >
    </span>
  </span>
</template>

<script>
import { join as _join, map as _map } from 'lodash'

export default {
  name: 'ColorfulBadge',

  props: {
    className: {
      default: '',
      type: String,
      require: false,
    },
    colors: {
      type: Array,
      default: null,
      require: true,
    },
  },

  computed: {
    linearGradient() {
      return _join(_map(this.colors, (value, index) => {
        return `${value} ${index / this.colors.length * 100}%, ${value} ${(index + 1) / this.colors.length * 100}%`
      }), ', ')
    },
  },
}
</script>

<style scoped>

</style>
