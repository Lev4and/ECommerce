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
        <router-link :to="{ name: 'Category', params: { url: url } }">
          <span>{{ categoryName }}</span>
        </router-link>
      </a-breadcrumb-item>
    </a-breadcrumb>
  </div>
</template>

<script>
export default {
  name: "Breadcrumb",

  props: {
    catalog: Object,
  },

  computed: {
    url() {
      return this.$route.params.url
    },
    currentCategory() {
      return this.catalog?.category
    },
    categoryName() {
      return this.currentCategory?.name || ""
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

<style>
.ant-breadcrumb .ant-breadcrumb-link a {
  color: #005bff !important;
  display: inline-block !important;
}
</style>

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
</style>
