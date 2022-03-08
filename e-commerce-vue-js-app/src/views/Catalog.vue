<template>
  <div id="catalog">
    <CategoriesTree />
  </div>
</template>

<script>
import CategoriesTree from '@/components/catalog/CategoriesTree'

export default {
  name: 'Catalog',

  components: {
    CategoriesTree,
  },
}
</script>

<style scoped>
#catalog {
  min-height: 100vh;
}
</style>
