<template>
  <div id="app">
    <a-layout id="components-layout-demo-fixed">
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
      <a-layout-content :style="{ padding: '0 50px', marginTop: '64px' }">
        <router-view />
      </a-layout-content>
      <a-layout-footer :style="{ textAlign: 'center' }">
        E-Commerce ©2022 Created by Lev4and
      </a-layout-footer>
    </a-layout>
  </div>
</template>

<style scoped></style>
