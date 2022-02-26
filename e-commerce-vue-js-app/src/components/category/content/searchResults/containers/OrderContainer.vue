<template>
  <div class="order-container">
    <AddToCart />
    <ExpressSubtitle :item="item" />
  </div>
</template>

<script>
import AddToCart from '@/components/category/content/searchResults/containers/orderContainer/AddToCart'
import ExpressSubtitle from '@/components/category/content/searchResults/containers/orderContainer/ExpressSubtitle'

export default {
  name: 'OrderContainer',

  components: {
    AddToCart,
    ExpressSubtitle,
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
