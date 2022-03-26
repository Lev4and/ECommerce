<template>
  <div id="aspectTypeUndefined">
    <span class="title">{{ aspect.type }}</span>
  </div>
</template>

<script>
export default {
  name: 'AspectTypeUndefined',

  props: {
    aspect: {
      type: Object,
      default: null,
      required: false,
    },
  },
}
</script>

<style scoped>

</style>
