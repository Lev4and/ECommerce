<template>
  <div id="category">
    <a-row>
      <a-col :span="24">
        <Breadcrumb :category="category" />
      </a-col>
      <a-col :span="24">
        <Header :category="category" />
      </a-col>
      <a-col :span="24">
        <TagList :category="category" />
      </a-col>
    </a-row>
    <a-layout>
      <Sider :category="category" />
      <Content :category="category" />
    </a-layout>
  </div>
</template>

<script>
import API from '@/api'
import Breadcrumb from '@/components/category/Breadcrumb'
import Header from '@/components/category/Header'
import TagList from '@/components/category/TagList'
import Sider from '@/components/category/Sider'
import Content from '@/components/category/Content'

export default {
  name: 'Category',

  components: {
    Breadcrumb,
    Header,
    TagList,
    Sider,
    Content,
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
