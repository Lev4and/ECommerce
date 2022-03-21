<template>
  <div class="order-container">
    <AddToCart />
  </div>
</template>

<script>
import AddToCart from '@/components/category/content/searchResults/containers/orderContainer/AddToCart'

export default {
  name: 'OrderContainer',

  components: {
    AddToCart,
  },

  props: {
    item: {
      type: Object,
      required: true,
    },
  },
}
</script>

<style scoped>
.order-container {
  display: flex;
  flex-direction: column;
}
</style>
