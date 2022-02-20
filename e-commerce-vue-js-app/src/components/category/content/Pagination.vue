<template>
  <a-pagination
    class="pagination"
    :total="totalPages"
    :default-current="currentPage"
  />
</template>

<script>
export default {
  name: 'Pagination',

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
    totalPages() {
      return this.catalog?.totalPages || 1
    },
    currentPage() {
      return this.catalog?.currentPage || 1
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
