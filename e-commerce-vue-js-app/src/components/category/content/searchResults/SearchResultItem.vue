<template>
  <div class="search-result-item">
    <ImageContainer :item="item" />
    <div class="info-price-order-container">
      <InfoContainer :item="item" />
      <div class="price-order-container">
        <PriceContainer :item="item" />
        <OrderContainer :item="item" />
      </div>
    </div>
  </div>
</template>

<script>
import ImageContainer from '@/components/category/content/searchResults/containers/ImageContainer'
import InfoContainer from '@/components/category/content/searchResults/containers/InfoContainer'
import PriceContainer from '@/components/category/content/searchResults/containers/PriceContainer'
import OrderContainer from '@/components/category/content/searchResults/containers/OrderContainer'

export default {
  name: 'SearchResultItem',

  components: {
    ImageContainer,
    InfoContainer,
    PriceContainer,
    OrderContainer,
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
div.search-result-item {
  grid-column-start: span 12;
  height: 100%;
  -webkit-user-drag: none;
  align-items: stretch;
  border-bottom: 1px solid #d2d9df;
  color: #001a34;
  display: flex;
  flex: 0 0 auto;
  flex-direction: row;
  justify-content: flex-start;
  justify-self: stretch;
  position: relative;
  -webkit-user-select: text;
  -moz-user-select: text;
  -ms-user-select: text;
  user-select: text;
  width: 100%;
}
div.search-result-item div.info-price-order-container {
  display: flex;
  width: inherit;
  flex-direction: row;
  justify-content: space-between;
}
div.search-result-item div.price-order-container {
  min-width: 300px;
  max-width: 300px;
  min-height: 200px;
  max-height: 200px;
  padding: 12px;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  align-self: center;
}
div.search-result-item div.price-order-container > div {
  display: flex;
}
</style>
