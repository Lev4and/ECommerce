<template>
  <a-select
    style="width: 230px"
  >
    <template v-for="item in sortings">
      <a-select-option
        :key="item.id"
        :value="item.value"
      >
        {{ item.name }}
      </a-select-option>
    </template>
  </a-select>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'Sorting',

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
    searchResultsSort() {
      return getWidget(this.widgets, 'searchResultsSort')
    },
    sortings() {
      return this.searchResultsSort?.sortings || []
    },
  },
}
</script>

<style scoped>

</style>
