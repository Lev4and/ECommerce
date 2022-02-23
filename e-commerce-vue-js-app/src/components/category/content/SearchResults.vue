<template>
  <div class="search-results-container">
    <template v-for="item in searchResults">
      <SearchResultItem :key="item.action.link" :item="item" />
    </template>
  </div>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'
import SearchResultItem from '@/components/category/content/searchResults/SearchResultItem'

export default {
  name: 'SearchResults',

  components: {
    SearchResultItem,
  },

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
  background-color: white;
}
</style>
