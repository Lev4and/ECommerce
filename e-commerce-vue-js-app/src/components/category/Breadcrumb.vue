<template>
  <div id="breadcrumb">
    <a-breadcrumb>
      <a-breadcrumb-item :key="0">
        <router-link :to="{ name: 'Home' }">
          <span>Каталог</span>
        </router-link>
      </a-breadcrumb-item>
      <template v-for="breadCrumb in breadCrumbs">
        <a-breadcrumb-item :key="breadCrumb.link">
          <router-link
            :to="{ name: 'Category', params: { url: breadCrumb.link } }"
          >
            <span>{{ breadCrumb.text }}</span>
          </router-link>
        </a-breadcrumb-item>
      </template>
      <a-breadcrumb-item :key="url">
        <router-link :to="{ name: 'Category', query: { url: url, p: 1 } }">
          <span>{{ categoryName }}</span>
        </router-link>
      </a-breadcrumb-item>
    </a-breadcrumb>
  </div>
</template>

<script>
export default {
  name: 'Breadcrumb',

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
    breadCrumbs() {
      if (this.catalog) {
        return this.catalog?.breadCrumbs || []
      }
      return []
    },
  },
}
</script>

<style scoped>
#breadcrumb {
  display: flex;
  align-items: center;
  flex-wrap: wrap;
  font-size: 14px;
  margin: 8px 0 6px;
  justify-content: flex-start;
  min-height: 26px;
}
#breadcrumb .ant-breadcrumb .ant-breadcrumb-link a {
  color: #005bff !important;
  display: inline-block !important;
}
</style>
