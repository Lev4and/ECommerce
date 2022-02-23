<template>
  <div class="search-result-item">
    <div class="main-image-container">
      <div class="image-container">
        <img :src="mainImage" />
      </div>
    </div>
    <div class="info-price-order-container">
      <div class="info-container">
        <a-row v-if="labels.length > 0">
          <a-col>
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
          </a-col>
        </a-row>
        <a-row>
          <a-col>
            <strong v-html="title" />
          </a-col>
        </a-row>
        <a-row v-if="topAttributes">
          <a-col>
            <div v-html="topAttributes" />
          </a-col>
        </a-row>
        <a-row>
          <a-col>
            <a-rate
              :disabled="true"
              :default-value="ratingValue"
            />
            <span class="ant-rate-text">({{ ratingValue.toFixed(2) }}) {{ ratingCount }}</span>
          </a-col>
        </a-row>
        <a-row v-if="colorVariants && colorVariantsItems.length > 0">
          <a-col>
            <div class="color-variants-container">
              <template v-for="(colorVariant, i) in colorVariantsItems">
                <template v-for="(color, j) in colorVariant.hex">
                  <a-tag
                    :key="`${i} - ${j}`"
                    :class="'tag'"
                  >
                    <a-badge
                      :color="color"
                      :class="'color-variants-item'"
                    />
                  </a-tag>
                </template>
              </template>
              <span v-if="colorVariantsText">{{ colorVariantsText }}</span>
            </div>
          </a-col>
        </a-row>
        <a-row v-if="textVariants && textVariantsItems.length > 0">
          <a-col>
            <div class="text-variants-container">
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
          </a-col>
        </a-row>
      </div>
      <div class="price-order-container">
        <div class="price-container">
          <div
            v-if="discount"
            class="discount-container"
          >
            <span>{{ discount }}</span>
          </div>
          <div class="current-original-price">
            <div class="current-price">
              <span style="color: #f5222d">{{ currentPrice }}</span>
            </div>
            <div
            v-if="originalPrice"
            class="original-price"
            >
              <span>{{ originalPrice }}</span>
            </div>
          </div>
        </div>
        <div class="order-container">
          <div class="add-to-cart">
            <a-button type="primary">
              <strong>
                В корзину
              </strong>
            </a-button>
          </div>
          <div
          class="express-subtitle"
          v-html="expressSubtitle"
          />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { head as _head, filter as _filter, find as _find } from 'lodash'

export default {
  name: 'SearchResultItem',

  props: {
    item: {
      type: Object,
      required: true,
    },
  },

  computed: {
    mainImage() {
      return _head(this.item.tileImage.images)
    },
    labels() {
      return _filter(this.item.mainState, (state) => state.id === 'label') || []
    },
    title() {
      return _find(this.item.mainState, (state) => state.id === 'name')?.atom?.textAtom?.text || 'Undefined'
    },
    topAttributes() {
      return _find(this.item.mainState, (state) => state.id === 'topAttributes')?.atom?.textAtom?.text || ''
    },
    rating() {
      return _find(this.item.mainState, (state) => state.id === 'atom' && state.atom.type === 'rating')
    },
    ratingValue() {
      return this.rating?.atom?.rating?.rating || 0
    },
    ratingCount() {
      return this.rating?.atom?.rating?.count || '0 отзывов'
    },
    colorVariants() {
      return _find(this.item.mainState, (state) => state.id === 'atom' && state.atom.type === 'colorVariants')
    },
    colorVariantsText() {
      return this.colorVariants?.atom?.colorVariants?.text || ''
    },
    colorVariantsItems() {
      return this.colorVariants?.atom?.colorVariants?.items || []
    },
    textVariants() {
      return _find(this.item.mainState, (state) => state.id === 'atom' && state.atom.type === 'textVariants')
    },
    textVariantsText() {
      return this.textVariants?.atom?.textVariants?.text || ''
    },
    textVariantsItems() {
      return this.textVariants?.atom?.textVariants?.items || []
    },
    discount() {
      return _find(this.item.rightState, (state) => state.id === 'badge' && state.atom.type === 'badge' &&
        state.atom.badge.theme === 'STYLE_TYPE_DISCOUNT')?.atom?.badge?.text || ''
    },
    price() {
      return _find(this.item.rightState, (state) => state.id === 'atom' && state.atom.type === 'price')?.atom?.price
    },
    currentPrice() {
      return this.price?.price || ''
    },
    originalPrice() {
      return this.price?.originalPrice || ''
    },
    expressSubtitle() {
      return this.item.multiButton?.expressSubtitle?.textAtomWithIcon?.text
    },
  },
}
</script>

<style>
div.search-result-item div.color-variants-container {
  display: flex;
  flex-direction: row;
}
div.search-result-item div.color-variants-container .tag .color-variants-item .ant-badge-status-dot {
  width: 12px !important;
  height: 12px !important;
}
div.search-result-item div.color-variants-container .tag .color-variants-item .ant-badge-status-text {
  display: none;
}
</style>

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
div.search-result-item div.main-image-container {
  max-width: 200px;
  min-width: 200px;
  min-height: 200px;
  max-height: 200px;
  padding: 12px;
  display: flex;
  align-self: center;
}
div.search-result-item div.main-image-container div.image-container {
  display: flex;
}
div.search-result-item div.main-image-container div.image-container img {
  width: 100%;
  height: 100%;
  object-fit: contain;
}
div.search-result-item div.info-price-order-container {
  display: flex;
  width: inherit;
  flex-direction: row;
  justify-content: space-between;
}
div.search-result-item div.info-container {
  padding: 12px;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
}
div.search-result-item div.info-container > div {
  margin: 5px 0;
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
div.search-result-item div.price-order-container div.price-container {
  display: flex;
  flex-direction: column;
}
div.search-result-item div.price-order-container div.price-container div.discount-container {
  align-items: center;
  border-radius: 12px;
  box-sizing: border-box;
  display: inline-flex;
  justify-content: center;
  overflow: hidden;
  font-size: 14px;
  height: 24px;
  line-height: 18px;
  padding: 3px 10px;
  flex-shrink: 0;
  font-weight: 700;
  color: rgb(255, 255, 255);
  background-color: rgb(249, 17, 85);
  width: fit-content;
}
div.search-result-item div.price-order-container div.price-container div.discount-container span {
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
  color: rgb(255, 255, 255);
  font-weight: 700;
  font-size: 14px;
  line-height: 18px;
}
div.search-result-item div.price-order-container div.price-container div.current-original-price {
  align-items: center;
  display: flex;
  flex-wrap: wrap;
}
div.search-result-item div.price-order-container div.price-container div.current-original-price div.original-price {
  font-size: 14px;
  line-height: 14px;
  position: relative;
  color: rgb(0, 26, 52);
}
div.search-result-item div.price-order-container div.price-container div.current-original-price div.current-price {
  color: rgb(249, 17, 85);
  font-size: 20px;
  font-weight: 700;
  line-height: 26px;
  margin: 0 4px 0 0;
}
div.search-result-item div.price-order-container div.order-container {
  display: flex;
  flex-direction: column;
}
</style>
