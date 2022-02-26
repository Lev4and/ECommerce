<template>
  <div id="sider">
    <a-layout-sider
      width="300"
      style="background: #fff"
    >
      <div class="layout-sider-content">
        <BlockCategory :categories="categories" />
        <template v-for="filter in filters">
          <FilterType
            :key="filter.key"
            :filter="filter"
          />
        </template>
        <BlockActions />
        <ModalAllFilters />
      </div>
    </a-layout-sider>
  </div>
</template>

<script>
import { map as _map } from 'lodash'
import { getWidget } from '@/services/utils/widgetsUtils'
import ModalAllFilters from '@/components/category/sider/ModalAllFilters'
import BlockCategory from '@/components/category/sider/blocks/BlockCategory'
import BlockActions from '@/components/category/sider/blocks/BlockActions'
import FilterType from '@/components/category/sider/FilterType'

export default {
  name: 'Sider',

  components: {
    ModalAllFilters,
    BlockCategory,
    BlockActions,
    FilterType,
  },

  props: {
    category: {
      type: Object,
      default: null,
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

  methods: {
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
div.layout-sider-content div.filter {
  margin: 12px 0;
}
div.layout-sider-content section {
  margin: 12px 0;
}
div.layout-sider-content section:first-child {
  margin: 0 0 12px 0;
}
</style>
