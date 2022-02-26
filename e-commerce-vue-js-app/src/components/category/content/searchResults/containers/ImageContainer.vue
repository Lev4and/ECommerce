<template>
  <div class="main-image-container">
    <div class="image-container">
      <img :src="mainImage" />
    </div>
  </div>
</template>

<script>
import { head as _head } from 'lodash'

export default {
  name: 'ImageContainer',

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
  },
}
</script>

<style scoped>
.main-image-container {
  max-width: 200px;
  min-width: 200px;
  min-height: 200px;
  max-height: 200px;
  padding: 12px;
  display: flex;
  align-self: center;
}
.main-image-container .image-container {
  display: flex;
}
.main-image-container .image-container img {
  width: 100%;
  height: 100%;
  object-fit: contain;
}
</style>
