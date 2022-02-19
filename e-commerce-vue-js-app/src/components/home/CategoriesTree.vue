<template>
  <a-tree
    :class="'tree-items-group'"
    :tree-data="categories"
  >
    <template
      slot="title"
      slot-scope="{ url, title }"
    >
      <router-link :to="{ name: 'Category', params: { url: url } }">
        <strong>{{ title }}</strong>
      </router-link>
    </template>
  </a-tree>
</template>

<script>
import { map as _map } from 'lodash'
import API from '@/api'

export default {
  name: 'CategoriesTree',

  data: () => ({
    categories: [],
  }),

  mounted() {
    this.loadCategories()
  },

  methods: {
    async loadCategories() {
      this.categories = this.mapCategories(
        (await API.category.getCategory()).categories,
      )
    },
    mapCategories(categories) {
      if (categories) {
        if (Array.isArray(categories)) {
          return _map(categories, (category) => {
            return {
              url: category.url,
              title: category.title,
              scopedSlots: { title: 'title' },
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

<style>
ul.tree-items-group.ant-tree li[role="treeitem"] span.ant-tree-node-content-wrapper {
  display: contents;
  white-space: pre-wrap;
}
</style>

<style scoped>
ul.tree-items-group {
  display: flex;
  flex-flow: column;
  align-items: flex-start;
}
</style>
