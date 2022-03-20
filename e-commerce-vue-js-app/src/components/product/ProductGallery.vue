<template>
  <div id="productGallery">
    <a-carousel
      arrows
      dots-class="slick-dots slick-thumb"
    >
      <a
        slot="customPaging"
        slot-scope="props"
      >
        <img :src="images[props.i].src">
      </a>
      <template v-for="image in images">
        <div :key="image.src">
          <img
            :src="image.src"
            :alt="image.alt"
          >
        </div>
      </template>
    </a-carousel>
  </div>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'ProductGallery',

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
    images() {
      return getWidget(this.widgets, 'webGallery')?.images || []
    },
  },
}
</script>

<style scoped>
.ant-carousel >>> .slick-dots {
  display: flex !important;
  justify-content: space-between !important;
  height: auto;
}
.ant-carousel >>> .slick-slide img {
  border: 5px solid #fff;
  display: flex;
  margin: auto;
  max-width: 80%;
  max-height: 300px;
  object-fit: contain;
}
.ant-carousel >>> .slick-thumb {
  bottom: -45px;
}
.ant-carousel >>> .slick-thumb li {
  width: 60px;
  height: 45px;
}
.ant-carousel >>> .slick-thumb li img {
  width: 100%;
  height: 100%;
  object-fit: contain;
  filter: grayscale(100%);
}
.ant-carousel >>> .slick-thumb li.slick-active img {
  filter: grayscale(0%);
}
</style>
