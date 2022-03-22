<template>
  <div class="sku-container-item">
    <a-row :gutter="[0,12]">
      <a-col
        :span="24"
        class="image-container"
      >
        <img :src="product.images[0]" />
      </a-col>
      <a-col :span="24">
        <a-row>
          <a-col :span="24">
            <strong class="actual-price">
              {{ currentPrice }} <sub v-if="originalPrice" class="original-price">{{ originalPrice }}</sub>
            </strong>
          </a-col>
        </a-row>
      </a-col>
      <a-col :span="24">
        <router-link :to="{ name: 'Product', query: { url: product.link } }">
          <span class="title">{{ title }}</span>
        </router-link>
      </a-col>
      <a-col :span="24">
        <a-rate
          :disabled="true"
          :default-value="ratingValue"
        />
        <span class="ant-rate-text">({{ ratingValue.toFixed(2) }})</span>
      </a-col>
      <a-col :span="24">
        <a-button type="primary">
          <strong>
            В корзину
          </strong>
        </a-button>
      </a-col>
    </a-row>
  </div>
</template>

<script>
import { find as _find } from 'lodash'

export default {
  name: 'SkuContainerItem',

  props: {
    product: {
      type: Object,
      default: null,
      required: false,
    },
  },

  computed: {
    states() {
      return this.product.state
    },
    title() {
      return _find(this.states, (state) => state.type === 'textAtom' &&
        state.textAtom?.testInfo?.automatizationId === 'title-name')?.textAtom?.text || ''
    },
    price() {
      return _find(this.states, (state) => state.type === 'price')?.price
    },
    currentPrice() {
      return this.price?.price
    },
    originalPrice() {
      return this.price?.originalPrice
    },
    ratingValue() {
      return _find(this.states, (state) => state.type === 'rating')?.rating?.rating || 0
    },
  },
}
</script>

<style scoped>
.sku-container-item {
  padding: 10px;
  border-radius: 10px;
  border: 1px solid black;
}
.image-container {
  width: 100%;
  height: 170px;
  display: flex;
  align-items: center;
  vertical-align: middle;
}
.image-container img {
  margin: auto;
  max-width: 90%;
  max-height: 90%;
  object-fit: contain;
}
.actual-price {
  font-size: 20px;
  color: rgb(249, 17, 85);
}
.original-price {
  color: black;
}
.original-price::after {
  height: 3px;
  content: "";
  display: block;
  left: 0;
  position: absolute;
  top: calc(50% - 1px);
  transform: rotate(-2deg);
  background-color: red;
  width: 100%;
}
.title {
  display: flex;
  overflow: hidden;
  min-height: 42px;
  max-height: 42px;
  text-overflow: ellipsis;
}
</style>
