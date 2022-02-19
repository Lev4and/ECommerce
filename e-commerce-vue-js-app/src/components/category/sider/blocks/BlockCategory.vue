<template>
  <SiderBlock :title="'Категории'">
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
  </SiderBlock>
</template>

<script>
import SiderBlock from '@/components/category/sider/SiderBlock'

export default {
  name: 'BlockCategory',

  components: {
    SiderBlock,
  },

  props: {
    categories: {
      type: Array,
      required: false,
    },
  },
}
</script>

<style>
ul.tree-items-group.ant-tree li[role="treeitem"] span.ant-tree-node-content-wrapper{
  display: contents;
  white-space: pre-wrap;
}
</style>

<style scoped>
ul.tree-items-group{
  display: flex;
  overflow: auto;
  flex-flow: column;
  max-height: 200px;
  align-items: flex-start;
}
</style>
