<template>
  <div id="aspectTypeColors" ref="aspectTypeColors">
    <span class="title">{{ title }}</span>
    <div class="variants">
      <template v-for="variant in variants">
        <a-tag
          :key="variant.link"
          :class="[ variant.availability !== 'inStock' ? 'disabled' : '' ]"
          :color="variant.active ? '#005bff': ''"
        >
          <a-tooltip :getPopupContainer="() => { return $refs.aspectTypeColors }">
            <template slot="title">
              <div class="variant-tooltip">
                <div class="variant-image">
                  <img :src="variant.data.coverImage" />
                </div>
                <a-divider type="horizontal" />
                  <strong class="variant-color-title">
                    {{ variant.data.textRs[0].content }}
                  </strong>
                <a-divider type="horizontal" />
                <div class="variant-price">
                  <strong class="actual-price">
                    {{ variant.data.price }} <sub v-if="variant.data.originalPrice" class="original-price">{{ variant.data.originalPrice }}</sub>
                  </strong>
                </div>
              </div>
            </template>
            <router-link :to="{ name: 'Product', query: { url: variant.link } }">
              <ColorfulBadge
                :colors="variant.data.colors"
                :className="'variant-color'"
              />
            </router-link>
          </a-tooltip>
        </a-tag>
      </template>
    </div>
  </div>
</template>

<script>
import { head as _head } from 'lodash'
import ColorfulBadge from '@/components/common/ColorfulBadge'

export default {
  name: 'AspectTypeColors',

  components: {
    ColorfulBadge,
  },

  props: {
    aspect: {
      type: Object,
      default: null,
      required: false,
    },
  },

  computed: {
    title() {
      return _head(this.aspect?.descriptionRs)?.content
    },
    variants() {
      return this.aspect?.variants || []
    },
  },
}
</script>

<style>
#aspectTypeColors .ant-tooltip-inner {
  background-color: white;
}
.variants .ant-tag .variant-color .ant-badge-status-dot {
  width: 24px !important;
  height: 24px !important;
  border: 1px black solid;
}
.variants .ant-tag .variant-color .ant-badge-status-text {
  display: none;
}
</style>

<style scoped>
#aspectTypeColors {
  display: flex;
  flex-direction: column;
}
.variants {
  display: flex;
  flex-wrap: wrap;
  margin-top: 12px;
  flex-direction: row;
}
.variants .ant-tag {
  padding: 7px 16px;
  background-color: white;
  border: 2px solid #f2f5f9;
}
.variants .ant-tag.disabled {
  background-color: gray;
}
.variants .ant-tag .variant-color:nth-child(2n) {
  margin: 0 5px;
}
.variant-tooltip {

}
.variant-tooltip .variant-image {
  width: 150px;
  height: 150px;
  margin: 0 auto;
}
.variant-tooltip .variant-image img {
  width: 100%;
  height: 100%;
  object-fit: contain;
}
.variant-tooltip .variant-color-title {
  display: flex;
  color: black;
  justify-content: center;
  text-transform: capitalize;
}
.variant-tooltip .variant-price {
  display: flex;
  align-items: center;
  flex-direction: row;
  justify-content: center;
}
.variant-price .actual-price {
  font-size: 18px;
  color: rgb(249, 17, 85);
}
.variant-price .original-price {
  color: black;
}
.variant-price .original-price::after {
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
</style>
