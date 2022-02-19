<template>
  <div id="sider">
    <a-layout-sider
      width="300"
      style="background: #fff"
    >
      <div class="layout-sider-content">
        <BlockCategory :categories="categories" />
        <template v-for="filter in filters">
          <template v-if="filter.ftype === 'RESPONSE_FILTER_TYPE_BOOL'">
            <FilterTypeBool
              :key="filter.key"
              :filter="filter"
            />
          </template>
          <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_RADIO'">
            <FilterTypeRadio
              :key="filter.key"
              :filter="filter"
            />
          </template>
          <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_RANGE'">
            <FilterTypeRange
              :key="filter.key"
              :filter="filter"
            />
          </template>
          <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_MULTI'">
            <FilterTypeMulti
              :key="filter.key"
              :filter="filter"
            />
          </template>
          <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_RATING'">
            <FilterTypeRating
              :key="filter.key"
              :filter="filter"
            />
          </template>
          <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_COLOR'">
            <FilterTypeColor
              :key="filter.key"
              :filter="filter"
            />
          </template>
          <template v-else>
            <FilterTypeUndefined
              :key="filter.key"
              :filter="filter"
            />
          </template>
        </template>
        <BlockActions />
      </div>
    </a-layout-sider>
  </div>
</template>

<script>
import { map as _map } from 'lodash'
import API from '@/api'
import { getWidget } from '@/services/utils/widgetsUtils'
import BlockCategory from '@/components/category/sider/blocks/BlockCategory'
import BlockActions from '@/components/category/sider/blocks/BlockActions'
import FilterTypeBool from '@/components/category/sider/filters/FilterTypeBool'
import FilterTypeRadio from '@/components/category/sider/filters/FilterTypeRadio'
import FilterTypeRange from '@/components/category/sider/filters/FilterTypeRange'
import FilterTypeMulti from '@/components/category/sider/filters/FilterTypeMulti'
import FilterTypeRating from '@/components/category/sider/filters/FilterTypeRating'
import FilterTypeColor from '@/components/category/sider/filters/FilterTypeColor'
import FilterTypeUndefined from '@/components/category/sider/filters/FilterTypeUndefined'

export default {
  name: 'Sider',

  components: {
    BlockCategory,
    BlockActions,
    FilterTypeBool,
    FilterTypeRadio,
    FilterTypeRange,
    FilterTypeMulti,
    FilterTypeRating,
    FilterTypeColor,
    FilterTypeUndefined,
  },

  props: {
    category: {
      type: Object,
      required: false,
    },
  },

  computed: {
    url() {
      return this.$route.params.url
    },
    widgets() {
      return this.category?.widgetStates
    },
    searchResultsFilters() {
      return getWidget(this.widgets, 'searchResultsFilters')
    },
    categories() {
      return this.mapCategories(this.searchResultsFilters?.categories)
    },
    filters() {
      return this.searchResultsFilters?.filters || []
    },
  },

  watch: {
    category: {
      handler() {
        this.isLoading = false
        this.loadAllFilters()
        this.isLoading = true
      },
      deep: true,
      immediate: true,
    },
  },

  methods: {
    async loadAllFilters() {
      this.allFilters = await API.catalog.getAllFilters(this.url, 1)
    },
    mapCategories(categories) {
      if (categories) {
        if (Array.isArray(categories)) {
          return _map(categories, (category) => {
            return {
              url: category.info.overrideUrl || `/category/${category.info.urlValue}`,
              title: category.info.name,
              scopedSlots: { title: 'title' },
              children: this.mapCategories(category.categories),
            }
          })
        }
      }
      return []
    },
  },
}
</script>

<style scoped>
div.layout-sider-content {
  padding: 10px;
}
div.layout-sider-content section {
  margin: 12px 0;
}
div.layout-sider-content section:first-child {
  margin: 0 0 12px 0;
}
</style>
