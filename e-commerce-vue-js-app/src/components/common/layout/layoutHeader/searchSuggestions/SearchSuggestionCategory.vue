<template>
  <a
    :href="searchSuggestion.deepLink"
    target="_blank"
  >
    {{ searchSuggestion.title }}
  </a>
</template>

<script>
import { searchSuggestion } from '@/services/mixins/searchSuggestionMixin'

export default {
  name: 'SearchSuggestionCategory',

  mixins: [searchSuggestion],
}
</script>

<style scoped>
a {
  align-items: center;
  color: #001a34;
  cursor: pointer;
  display: flex;
  font-size: 14px;
  line-height: 1.25;
  margin-top: 1px;
  padding: 6px 6px 6px 0;
  position: relative;
}
</style>
