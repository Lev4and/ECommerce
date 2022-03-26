<template>
  <a-layout-content :class="'category-layout-content'">
    <a-row :gutter="[0,48]">
      <a-col :span="24">
        <Sorting />
      </a-col>
      <a-col :span="24">
        <FiltersActive />
      </a-col>
      <a-col :span="24">
        <SearchResults />
      </a-col>
      <a-col :span="24">
        <Pagination />
      </a-col>
      <a-col :span="24">
        <SemanticText />
      </a-col>
    </a-row>
  </a-layout-content>
</template>

<script>
import Sorting from '@/components/category/content/Sorting'
import FiltersActive from '@/components/category/content/FiltersActive'
import SearchResults from '@/components/category/content/SearchResults'
import Pagination from '@/components/category/content/Pagination'
import SemanticText from '@/components/category/content/SemanticText'

export default {
  name: 'Content',

  components: {
    Sorting,
    FiltersActive,
    SearchResults,
    Pagination,
    SemanticText,
  },
}
</script>

<style scoped>
main.category-layout-content {
  margin-left: 24px;
}
</style>
