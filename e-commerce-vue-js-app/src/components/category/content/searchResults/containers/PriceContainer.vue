<template>
  <div class="price-container">
    <Discount :item="item" />
    <Price :item="item" />
  </div>
</template>

<script>
import Discount from '@/components/category/content/searchResults/containers/priceContainer/Discount'
import Price from '@/components/category/content/searchResults/containers/priceContainer/Price'

export default {
  name: 'PriceContainer',

  components: {
    Discount,
    Price,
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
.price-container {
  display: flex;
  flex-direction: column;
}
.price-container div + div {
  margin-top: 10px;
}
</style>
