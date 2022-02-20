<template>
  <a-auto-complete
    class="global-search"
    size="large"
    style="width: 100%"
    ref="autoComplete"
    placeholder="Искать на E-Commerce"
    option-label-prop="title"
    @select="onSelect"
    @search="handleSearch"
  >
    <template slot="dataSource">
      <a-select-option
        v-for="item in searchSuggestions"
        :key="item.link"
        :title="item.title"
      >
        <template v-if="item.meta.type === 'suggests'">
          <SearchSuggestionSuggests
            :key="item.link"
            :searchSuggestion="item"
          />
        </template>
        <template v-else-if="item.meta.type === 'category'">
          <SearchSuggestionCategory
            :key="item.link"
            :searchSuggestion="item"
          />
        </template>
        <template v-else-if="item.meta.type === 'brand'">
          <SearchSuggestionBrand
            :key="item.link"
            :searchSuggestion="item"
          />
        </template>
        <template v-else-if="item.meta.type === 'item'">
          <SearchSuggestionItem
            :key="item.link"
            :searchSuggestion="item"
          />
        </template>
        <template v-else>
          <SearchSuggestionUndefined
            :key="item.link"
            :searchSuggestion="item"
          />
        </template>
      </a-select-option>
    </template>
    <a-input>
      <a-button
        slot="suffix"
        style="margin-right: -12px"
        class="search-btn"
        size="large"
        type="primary"
      >
        <a-icon type="search" />
      </a-button>
    </a-input>
  </a-auto-complete>
</template>

<script>
import API from '@/api'
import { getWidget } from '@/services/utils/widgetsUtils'
import SearchSuggestionSuggests from '@/components/common/layout/layoutHeader/searchSuggestions/SearchSuggestionSuggests'
import SearchSuggestionCategory from '@/components/common/layout/layoutHeader/searchSuggestions/SearchSuggestionCategory'
import SearchSuggestionBrand from '@/components/common/layout/layoutHeader/searchSuggestions/SearchSuggestionBrand'
import SearchSuggestionItem from '@/components/common/layout/layoutHeader/searchSuggestions/SearchSuggestionItem'
import SearchSuggestionUndefined from '@/components/common/layout/layoutHeader/searchSuggestions/SearchSuggestionUndefined'

export default {
  name: 'LayoutHeaderAutoComplete',

  data: () => ({
    dataSource: [],
    searchResult: null,
  }),

  components: {
    SearchSuggestionSuggests,
    SearchSuggestionCategory,
    SearchSuggestionBrand,
    SearchSuggestionItem,
    SearchSuggestionUndefined,
  },

  computed: {
    url() {
      return this.$route.params.url
    },
    widgets() {
      return this.searchResult?.widgetStates
    },
    searchSuggestions() {
      return getWidget(this.widgets, 'searchSuggestions')?.items || []
    },
  },

  methods: {
    onSelect(value) {
      console.log('onSelect', value)
    },
    async handleSearch(value) {
      this.searchResult = await API.catalog.getSearchSuggestions(this.url, value)
    },
  },
}
</script>

<style scoped>
.global-search {
  width: 100%;
}

.global-search.ant-select-auto-complete .ant-select-selection--single {
  margin-right: -46px;
}

.global-search.ant-select-auto-complete .ant-input-affix-wrapper .ant-input:not(:last-child) {
  padding-right: 62px;
}

.global-search.ant-select-auto-complete .ant-input-affix-wrapper .ant-input-suffix button {
  border-top-left-radius: 0;
  border-bottom-left-radius: 0;
}

.global-search-item {
  display: flex;
}

.global-search-item-desc {
  flex: auto;
  text-overflow: ellipsis;
  overflow: hidden;
}

.global-search-item-count {
  flex: none;
}
</style>
