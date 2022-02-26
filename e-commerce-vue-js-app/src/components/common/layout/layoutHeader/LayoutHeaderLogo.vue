<template>
  <router-link :to="{ name: 'Home' }">
    <img :src="require('@/assets/logo.png')">
  </router-link>
</template>

<script>
export default {
  name: 'LayoutHeaderLogo',
}
</script>

<style scoped>
a {
  align-items: center;
  display: flex;
  height: 40px;
  justify-content: flex-start;
}
a img {
  max-height: 100%;
  max-width: 100%;
}
</style>
