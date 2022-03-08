<template>
  <a-modal
    v-model="visible"
    title="Все фильтры"
    :class="'modal-all-filters'"
    :cancel-text="'Закрыть'"
    :ok-text="'Применить'"
    @ok="applyFilters"
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
import API from '@/api'
import EventBus from '@/services/eventBus.js'
import { getWidget } from '@/services/utils/widgetsUtils'
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
      return this.$route.query.url
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
      handler(newValue, oldValue) {
        if (newValue !== oldValue) {
          this.loadAllFilters()
        }
      },
      deep: true,
      immediate: true,
    },
  },

  mounted() {
    EventBus.$on('show-all-filters', this.showAllFilters)
  },

  beforeDestroy() {
    EventBus.$off('show-all-filters', this.showAllFilters)
  },

  methods: {
    async loadAllFilters() {
      this.allFilters = await API.catalog.getAllFilters(this.url)
    },
    showAllFilters() {
      this.visible = true
    },
    applyFilters() {
      EventBus.$emit('apply-filters')
    },
  },
}
</script>

<style scoped>
div.modal-all-filters div.filter {
  margin: 12px 0;
}
</style>
