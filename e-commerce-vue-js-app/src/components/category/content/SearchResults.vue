<template>
  <div class="search-results-container">
    <template v-for="item in searchResults">
      <SearchResultItem
        :key="item.action.link"
        :item="item"
      />
    </template>
  </div>
</template>

<script>
import { mapGetters } from 'vuex'
import SearchResultItem from '@/components/category/content/searchResults/SearchResultItem'

export default {
  name: 'SearchResults',

  components: {
    SearchResultItem,
  },

  computed: {
    ...mapGetters({
      searchResults: 'category/searchResults',
    }),
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
