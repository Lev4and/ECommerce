<template>
  <div id="productPrice">
    <a-row :gutter="[0,8]">
      <a-col :span="24">
        <a-row
          :gutter="[16,0]"
          type="flex"
        >
          <a-col>
            <h1 class="actual-price">
              {{ actualPrice }} <sub v-if="originalPrice" class="original-price">{{ originalPrice }}</sub>
            </h1>
          </a-col>
        </a-row>
      </a-col>
      <a-col :span="24">
        <a-row
          type="flex"
          align="middle"
        >
          <a-col
            :span="24"
            style="display: flex; align-items: center;"
          >
            <strong class="payment">{{ payment }}</strong>
            <span> × {{ paymentTerm }}</span>
            <span style="margin-left: 6px;">
              <a-tooltip
                v-if="hintText"
                slot="suffix"
              >
                <template slot="title">
                  <span>{{ hintText }}</span>
                </template>
                <a-icon
                  type="info-circle"
                  style="color: rgba(0,0,0,.45)"
                />
              </a-tooltip>
            </span>
          </a-col>
        </a-row>
      </a-col>
    </a-row>
  </div>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'ProductPrice',

  props: {
    product: {
      type: Object,
      default: null,
      required: false,
    },
  },

  computed: {
    widgets() {
      return this.product?.widgetStates
    },
    price() {
      return getWidget(this.widgets, 'webPrice')
    },
    actualPrice() {
      return this.price?.price
    },
    originalPrice() {
      return this.price?.originalPrice
    },
    payment() {
      return this.price?.payment
    },
    paymentTerm() {
      return this.price?.paymentTerm
    },
    hintText() {
      return this.price?.hintText
    },
  },
}
</script>

<style scoped>
.actual-price {
  font-size: 30px;
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
.payment {
  padding: 0 6px;
  font-size: 20px;
  color: #001a34;
  background-color: #ffd540;
}
</style>
