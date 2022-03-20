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
import { mapGetters } from 'vuex'
import { map as _map } from 'lodash'
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

  computed: {
    ...mapGetters({
      resultsFilters: 'category/resultsFilters',
    }),
    url() {
      return this.$route.query.url
    },
    categories() {
      return this.mapCategories(this.resultsFilters?.categories)
    },
    filters() {
      return this.resultsFilters?.filters || []
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
