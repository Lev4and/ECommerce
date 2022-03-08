<template>
  <div
    v-if="filters.length > 0"
    id="filtersActive"
  >
    <template v-for="filter in filters">
      <template v-for="value in filter.activeValues">
        <a-tag
          :key="`${filter.name}:${value.title}`"
          :class="'tag'"
          :closable="true"
        >
          {{ filter.name }}: {{ value.title }}
        </a-tag>
      </template>
    </template>
    <a-tag
      :class="'tag'"
      :closable="true"
    >
      Очистить всё
    </a-tag>
  </div>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'FiltersActive',

  props: {
    category: {
      type: Object,
      default: null,
      required: false,
    },
  },

  computed: {
    widgets() {
      return this.category?.widgetStates
    },
    filtersActive() {
      return getWidget(this.widgets, 'searchResultsFiltersActive')
    },
    filters() {
      return this.filtersActive?.activeFilters || []
    },
  },
}
</script>

<style scoped>
#filtersActive {
  align-items: center;
  box-sizing: border-box;
  display: flex;
  flex-wrap: wrap;
  justify-content: flex-start;
  margin-bottom: 18px;
  min-height: 38px;
}
#filtersActive .tag {
  align-items: center;
  background: #eff3f6;
  border-radius: 16px;
  box-sizing: border-box;
  color: #001a34;
  display: flex;
  flex: 0 0 auto;
  font-size: 14px;
  height: 32px;
  margin: 0 6px 6px 0;
  padding: 6px 16px;
}
</style>
