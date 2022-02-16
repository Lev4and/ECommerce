<template>
  <div id="home">
    <a-spin :spinning="!isLoading">
      <a-tree :treeData="categories">
        <template slot="title" slot-scope="{ url, title }">
          <router-link :to="{ name: 'Category', params: { url: url } }">
            <strong>{{ title }}</strong>
          </router-link>
        </template>
      </a-tree>
    </a-spin>
  </div>
</template>

<script>
import { map as _map } from "lodash"
import API from "@/api"

export default {
  name: "Home",

  data: () => ({
    isLoading: false,
    categories: [],
  }),

  mounted() {
    this.isLoading = false
    this.loadCategories()
    this.isLoading = true
  },

  methods: {
    async loadCategories() {
      this.categories = this.mapCategories(
        (await API.category.getCategory()).categories
      )
    },
    mapCategories(categories) {
      if (categories) {
        if (Array.isArray(categories)) {
          return _map(categories, (category) => {
            return {
              url: category.url,
              title: category.title,
              scopedSlots: { title: "title" },
              children: this.mapCategories(category.categories),
            }
          })
        }
      }
      return []
    },
  },
}
</script>

<style scoped>
#home {
  min-height: 100vh;
}
</style>
