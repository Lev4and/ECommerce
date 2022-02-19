<template>
  <div id="home">
    <CategoriesTree />
  </div>
</template>

<script>
import CategoriesTree from '@/components/home/CategoriesTree'

export default {
  name: 'Home',

  components: {
    CategoriesTree,
  },
}
</script>

<style scoped>
#home {
  min-height: 100vh;
}
</style>
