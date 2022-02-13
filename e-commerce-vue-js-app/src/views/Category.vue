<template>
  <div id="category">
    <a-breadcrumb>
      <a-breadcrumb-item :key="0">
        <router-link :to="{ name: 'Home' }">
          <span>Каталог</span>
        </router-link>
      </a-breadcrumb-item>
      <template v-for="breadCrumb in breadCrumbs">
        <a-breadcrumb-item :key="breadCrumb.link">
          <router-link :to="{ name: 'Category', params: { url: breadCrumb.link } }">
            <span>{{ breadCrumb.text }}</span>
          </router-link>
        </a-breadcrumb-item>
      </template>
      <a-breadcrumb-item :key="url">
        <router-link :to="{ name: 'Category', params: { url: url } }">
          <span>{{ categoryName }}</span>
        </router-link>
      </a-breadcrumb-item>
    </a-breadcrumb>
    <h1>{{ categoryName }}<sup>{{ totalFound }}</sup></h1>
    <template v-for="tag in tagList">
      <a-tag :key="tag.link">{{ tag.name }}</a-tag>
    </template>
  </div>
</template>

<script>
  import API from '@/api'
  import { getWidget } from '@/services/utils/widgetsUtils'

  export default {
    name: 'Category',

    data: () => ({
      isLoading: false,
      category: null,
      listing: []
    }),

    watch: {
      url: {
        handler() {
          this.isLoading = false
          this.loadCategory()
          this.isLoading = true
        },
        deep: true,
        immediate: true,
      }
    },

    computed: {
      url() {
        return this.$route.params.url
      },
      shared() {
        if(this.category) {
          if(this.category?.shared && this.category?.shared?.length > 0) {
            return JSON.parse(this.category?.shared)
          }
        }
        return null
      },
      widgets() {
        return this.category?.widgetStates
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
      breadCrumbs() {
        if(this.catalog) {
          return this.catalog?.breadCrumbs || []
        }
        return []
      },
      catalogResultsHeader() {
        return getWidget(this.widgets, 'catalogResultsHeader')
      },
      totalFound() {
        return this.catalogResultsHeader?.totalFound || '0 товаров'
      },
      tagList() {
        return getWidget(this.widgets, 'tagList')?.items || []
      },
    },

    methods: {
      async loadCategory() {
        this.category = await API.catalog.getCatalog(this.url, 1)
      },
    }
  }
</script>

<style scoped>
  #category{
    min-height: 100vh;
  }
</style>
