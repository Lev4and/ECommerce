<template>
  <router-link :to="{ name: 'Home' }">
    <a-button type="primary">
      <a-icon type="unordered-list" /> Каталог
    </a-button>
  </router-link>
</template>

<script>
export default {
  name: 'LayoutHeaderButton',
}
</script>

<style scoped>
button {
  width: 100%;
  height: 40px;
}
</style>
