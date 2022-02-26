<template>
  <div id="header">
    <h1>
      {{ categoryName }}<sup>{{ totalFound }}</sup>
    </h1>
  </div>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'Header',

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
    catalogResultsHeader() {
      return getWidget(this.widgets, 'catalogResultsHeader')
    },
    totalFound() {
      return this.catalogResultsHeader?.totalFound || '0 товаров'
    },
    shared() {
      if (this.category) {
        if (this.category?.shared && this.category?.shared?.length > 0) {
          return JSON.parse(this.category?.shared)
        }
      }
      return null
    },
    catalog() {
      return this.shared?.catalog
    },
    currentCategory() {
      return this.catalog?.category
    },
    categoryName() {
      return this.currentCategory?.name || ''
    },
  },
}
</script>

<style scoped>
#header {
  align-items: center;
  display: flex;
  margin-top: 16px;
  margin-bottom: 16px;
}
#header h1 {
  font-size: 30px;
  font-weight: 700;
  line-height: 38px;
}
#header h1 sup {
  color: #96a3ae;
  font-size: 14px;
  margin-left: 4px;
}
</style>
