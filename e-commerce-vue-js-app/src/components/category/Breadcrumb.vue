<template>
  <div id="breadcrumb">
    <a-breadcrumb>
      <a-breadcrumb-item :key="0">
        <router-link :to="{ name: 'Catalog' }">
          <span>Каталог</span>
        </router-link>
      </a-breadcrumb-item>
      <template v-for="breadCrumb in breadCrumbs">
        <a-breadcrumb-item :key="breadCrumb.link">
          <router-link
            :to="{ name: 'Category', query: { url: breadCrumb.link } }"
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
import { mapGetters } from 'vuex'

export default {
  name: 'Breadcrumb',

  computed: {
    ...mapGetters({
      breadCrumbs: 'category/breadCrumbs',
      categoryName: 'category/name',
    }),
    url() {
      return this.$route.query.url
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
