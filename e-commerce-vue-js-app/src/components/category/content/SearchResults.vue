<template>
  <div class="search-results-container">
    <template v-for="item in searchResults">
      <div
      :key="item.action.link"
      class="search-result-item"
      >
        <div class="carousel-container">

        </div>
      </div>
    </template>
  </div>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'SearchResults',

  props: {
    category: {
      type: Object,
      required: false,
    },
  },

  computed: {
    widgets() {
      return this.category?.widgetStates
    },
    searchResults() {
      return getWidget(this.widgets, 'searchResultsV2')?.items || []
    },
  },
}
</script>

<style scoped>
div.search-results-container {
  align-items: stretch;
  flex-wrap: wrap;
  justify-content: flex-start;
  transform: translateZ(0);
  grid-gap: 1px;
  display: grid;
  grid-template-columns: repeat(12,1fr);
  justify-items: center;
}
div.search-results-container div.search-result-item {
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
div.search-result-item div.carousel-container {
  box-sizing: border-box;
  flex: 25 25 25%;
  max-width: 25%;
  min-width: 25%;
  min-height: 200px;
  max-height: 200px;
  padding: 12px 12px 0;
  width: 25%;
}
</style>
