<template>
  <div id="category">
    <a-spin
      :spinning="!isLoading"
    >
      <a-icon
        slot="indicator"
        type="loading"
        style="font-size: 96px"
        spin
      />
      <a-row>
        <a-col :span="24">
          <Breadcrumb />
        </a-col>
        <a-col :span="24">
          <Header />
        </a-col>
        <a-col :span="24">
          <TagList />
        </a-col>
      </a-row>
      <a-layout>
        <Sider />
        <Content />
      </a-layout>
      <a-col :span="24">
        <CategoryGoods />
      </a-col>
    </a-spin>
  </div>
</template>

<script>
import { set as _set, omit as _omit, cloneDeep as _cloneDeep } from 'lodash'
import API from '@/api'
import EventBus from '@/services/eventBus.js'
import Breadcrumb from '@/components/category/Breadcrumb'
import Header from '@/components/category/Header'
import TagList from '@/components/category/TagList'
import Sider from '@/components/category/Sider'
import Content from '@/components/category/Content'
import CategoryGoods from '@/components/category/content/CategoryGoods'

export default {
  name: 'Category',

  components: {
    Breadcrumb,
    Header,
    TagList,
    Sider,
    Content,
    CategoryGoods,
  },

  data: () => ({
    isLoading: false,
    category: null,
    listing: [],
    allFilters: [],
    activeKey: 1,
  }),

  computed: {
    query() {
      return _cloneDeep(this.$route.query)
    },
    url() {
      return this.query.url
    },
    page() {
      return this.query.p
    },
    sorting() {
      return this.query.sorting
    },
    filters() {
      return this.query.filters ? JSON.parse(this.query.filters) : {}
    },
  },

  watch: {
    url: {
      handler(newValue, oldValue) {
        if (newValue !== oldValue) {
          this.loadCategory()
        }
      },
      deep: true,
      immediate: true,
    },
  },

  mounted() {
    EventBus.$on('current-page-changed', this.onCurrentPageChanged)
    EventBus.$on('apply-filters', this.applyFilters)
    EventBus.$on('reset-filters', this.resetFilters)
  },

  beforeDestroy() {
    EventBus.$off('current-page-changed', this.onCurrentPageChanged)
    EventBus.$off('apply-filters', this.applyFilters)
    EventBus.$off('reset-filters', this.resetFilters)
  },

  methods: {
    async load(func) {
      try {
        this.isLoading = false
        await func()
        await this.$store.dispatch('category/init', this.category)
      } finally {
        this.isLoading = true
      }
    },
    async loadCategory() {
      this.load(async () => {
        this.category = await API.catalog.getCatalog(this.url, this.page, this.filters, this.sorting)
      })
    },
    async applyFilters() {
      this.load(async () => {
        this.category = await API.catalog.getCatalog(this.url, this.page, this.filters, this.sorting)
        EventBus.$emit('load-all-filters')
      })
    },
    async resetFilters() {
      this.load(async () => {
        this.category = await API.catalog.getCatalog(this.url, 1)
        this.$router.push({ query: _set(_omit(_omit(this.query, 'filters'), 'sorting'), 'p', 1) })
        EventBus.$emit('load-all-filters')
      })
    },
    async onCurrentPageChanged(page) {
      this.load(async () => {
        this.category = await API.catalog.getCatalog(this.url, page, this.filters, this.sorting)
        this.$router.push({ query: _set(this.query, 'p', page) })
      })
    },
  },
}
</script>

<style>
#category .ant-spin.ant-spin-spinning {
  top: 50% !important;
  left: 50% !important;
  z-index: 4 !important;
  width: auto !important;
  height: auto !important;
  position: fixed !important;
  margin-top: -48px !important;
  margin-left: -48px !important;
}
</style>

<style scoped>
#category {
  min-height: 100vh;
  margin: 24px auto 0;
}
</style>
