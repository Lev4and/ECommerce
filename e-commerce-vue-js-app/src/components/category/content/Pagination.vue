<template>
  <a-pagination
    class="pagination"
    :total="totalPages"
    :current="currentPage"
    @change="onCurrentPageChanged"
  />
</template>

<script>
import EventBus from '@/services/eventBus.js'

export default {
  name: 'Pagination',

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
    shared() {
      if (this.category) {
        if (this.category?.shared?.length > 0) {
          return JSON.parse(this.category?.shared)
        }
      }
      return null
    },
    catalog() {
      return this.shared?.catalog
    },
    totalPages() {
      return this.catalog?.totalPages * 10 || 1
    },
    currentPage() {
      return this.catalog?.currentPage || 1
    },
  },

  methods: {
    onCurrentPageChanged(page) {
      EventBus.$emit('current-page-changed', page)
    },
  },
}
</script>

<style scoped>
ul.pagination {
  display: flex;
  flex-direction: row;
  justify-content: center;
}
</style>
