<template>
  <img :src="product.images[0]">
</template>

<script>
export default {
  name: 'SkuContainerItem',

  props: {
    product: {
      type: Object,
      default: null,
      required: false,
    },
  },
}
</script>

<style scoped>

</style>
