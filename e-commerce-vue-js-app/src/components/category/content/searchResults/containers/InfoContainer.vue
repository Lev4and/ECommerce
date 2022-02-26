<template>
  <div class="info-container">
    <a-row>
      <a-col>
        <LabelsList :item="item" />
      </a-col>
    </a-row>
    <a-row>
      <a-col>
        <Title :item="item" />
      </a-col>
    </a-row>
    <a-row>
      <a-col>
        <TopAttributes :item="item" />
      </a-col>
    </a-row>
    <a-row>
      <a-col>
        <Rating :item="item" />
      </a-col>
    </a-row>
    <a-row>
      <a-col>
        <ColorVariants :item="item" />
      </a-col>
    </a-row>
    <a-row>
      <a-col>
        <TextVariants :item="item" />
      </a-col>
    </a-row>
  </div>
</template>

<script>
import LabelsList from '@/components/category/content/searchResults/containers/infoContainer/LabelsList'
import Title from '@/components/category/content/searchResults/containers/infoContainer/Title'
import TopAttributes from '@/components/category/content/searchResults/containers/infoContainer/TopAttributes'
import Rating from '@/components/category/content/searchResults/containers/infoContainer/Rating'
import ColorVariants from '@/components/category/content/searchResults/containers/infoContainer/ColorVariants'
import TextVariants from '@/components/category/content/searchResults/containers/infoContainer/TextVariants'

export default {
  name: 'InfoContainer',

  components: {
    LabelsList,
    Title,
    TopAttributes,
    Rating,
    ColorVariants,
    TextVariants,
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
.info-container {
  padding: 12px;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
}
.info-container > div {
  margin: 5px 0;
}
</style>
