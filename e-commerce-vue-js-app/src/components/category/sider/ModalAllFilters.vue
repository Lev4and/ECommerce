<template>
  <a-modal
    v-model="visible"
    title="Все фильтры"
    :class="'modal-all-filters'"
  >
    <template v-for="filter in filters">
      <FilterType
        :key="filter.key"
        :filter="filter"
      />
    </template>
  </a-modal>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'
import API from '@/api'
import EventBus from '@/services/eventBus.js'
import FilterType from '@/components/category/sider/FilterType'

export default {
  name: 'ModalAllFilters',

  components: {
    FilterType,
  },

  data: () => ({
    visible: false,
    allFilters: null,
  }),

  computed: {
    url() {
      return this.$route.params.url
    },
    widgets() {
      return this.allFilters?.widgetStates
    },
    searchResultsFilters() {
      return getWidget(this.widgets, 'searchResultsFilters')
    },
    filters() {
      return this.searchResultsFilters?.filters || []
    },
  },

  watch: {
    url: {
      handler() {
        this.loadAllFilters()
      },
      deep: true,
      immediate: true,
    },
  },

  mounted() {
    EventBus.$on('showAllFilters', this.showAllFilters)
  },

  beforeDestroy() {
    EventBus.$off('showAllFilters', this.showAllFilters)
  },

  methods: {
    async loadAllFilters() {
      this.allFilters = await API.catalog.getAllFilters(this.url)
    },
    showAllFilters() {
      this.visible = true
    },
  },
}
</script>

<style scoped>
div.modal-all-filters div.filter {
  margin: 12px 0;
}
</style>
