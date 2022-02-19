<template>
  <a-layout-header :style="{ position: 'fixed', zIndex: 1, width: '100%' }">
    <a-menu
      theme="dark"
      mode="horizontal"
      :style="{ lineHeight: '64px' }"
    >
      <a-menu-item key="1">
        <router-link :to="{ name: 'Home' }">
          <span>Каталог</span>
        </router-link>
      </a-menu-item>
    </a-menu>
  </a-layout-header>
</template>

<script>
export default {
  name: 'LayoutHeader',
}
</script>

<style scoped>

</style>
