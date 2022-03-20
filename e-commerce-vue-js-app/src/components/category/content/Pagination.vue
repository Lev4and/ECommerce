<template>
  <a-pagination
    class="pagination"
    :total="totalPages"
    :current="currentPage"
    @change="onCurrentPageChanged"
  />
</template>

<script>
import { mapGetters } from 'vuex'
import EventBus from '@/services/eventBus.js'

export default {
  name: 'Pagination',

  computed: {
    ...mapGetters({
      catalog: 'category/catalog',
    }),
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
