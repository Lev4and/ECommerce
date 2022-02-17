<template>
  <div id="category">
    <Breadcrumb :category="category" />
    <Header :category="category" />
    <TagList :category="category" />
    <a-layout>
      <Sider :category="category" />
      <a-layout-content />
    </a-layout>
  </div>
</template>

<script>
import API from '@/api'
import Breadcrumb from '@/components/category/Breadcrumb'
import Header from '@/components/category/Header'
import TagList from '@/components/category/TagList'
import Sider from '@/components/category/Sider'

export default {
  name: 'Category',

  components: {
    Breadcrumb,
    Header,
    TagList,
    Sider,
  },

  data: () => ({
    isLoading: false,
    category: null,
    listing: [],
    allFilters: [],
    activeKey: 1,
  }),

  computed: {
    url() {
      return this.$route.params.url
    },
  },

  watch: {
    url: {
      handler() {
        this.isLoading = false
        this.loadCategory()
        this.isLoading = true
      },
      deep: true,
      immediate: true,
    },
  },

  methods: {
    async loadCategory() {
      this.category = await API.catalog.getCatalog(this.url, 1)
    },
  },
}
</script>

<style scoped>
#category {
  min-height: 100vh;
  margin: 24px auto 0;
}
</style>
