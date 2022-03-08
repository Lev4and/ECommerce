<template>
  <router-link :to="{ name: 'Catalog' }">
    <a-button type="primary">
      <strong>
        <a-icon type="unordered-list" /> Каталог
      </strong>
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
