<template>
  <a-select
    style="width: 230px"
    :value="sortingValue"
  >
    <template v-for="item in sortings">
      <a-select-option
        :key="item.id"
        :value="item.id"
      >
        {{ item.name }}
      </a-select-option>
    </template>
  </a-select>
</template>

<script>
import { find as _find } from 'lodash'
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'Sorting',

  props: {
    category: {
      type: Object,
      default: null,
      required: false,
    },
  },

  computed: {
    url() {
      return this.$route.query.url
    },
    widgets() {
      return this.category?.widgetStates
    },
    searchResultsSort() {
      return getWidget(this.widgets, 'searchResultsSort')
    },
    sortings() {
      return this.searchResultsSort?.sortings || []
    },
    sortingValue() {
      return _find(this.sortings, (value) => value.isActive)?.id
    },
  },
}
</script>

<style scoped>

</style>
