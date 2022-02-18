<template>
  <SiderBlock :title="'Категории'">
    <a-tree :tree-data="categories">
      <template slot="title" slot-scope="{ url, title }">
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

  props: {
    categories: Array,
  },

  components: {
    SiderBlock,
  },
}
</script>

<style scoped>

</style>
