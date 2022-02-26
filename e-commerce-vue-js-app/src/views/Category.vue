<template>
  <div id="category">
    <a-spin :spinning="!isLoading">
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
    </a-spin>
  </div>
</template>

<script>
import API from '@/api'
import EventBus from '@/services/eventBus.js'
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
        this.loadCategory()
      },
      deep: true,
      immediate: true,
    },
  },

  mounted() {
    EventBus.$on('current-page-changed', this.onCurrentPageChanged)
  },

  beforeDestroy() {
    EventBus.$off('current-page-changed', this.onCurrentPageChanged)
  },

  methods: {
    async loadCategory() {
      this.isLoading = false
      this.category = await API.catalog.getCatalog(this.url, 1)
      this.isLoading = true
    },
    async onCurrentPageChanged(page) {
      this.isLoading = false
      this.category = await API.catalog.getCatalog(this.url, page)
      this.isLoading = true
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
