<template>
  <div id="app">
    <a-layout id="components-layout-demo-fixed">
      <LayoutHeader />
      <LayoutContent />
      <LayoutFooter />
    </a-layout>
    <BackToTop />
  </div>
</template>

<script>
import LayoutHeader from '@/components/common/layout/LayoutHeader'
import LayoutContent from '@/components/common/layout/LayoutContent'
import LayoutFooter from '@/components/common/layout/LayoutFooter'
import BackToTop from '@/components/common/BackToTop'

export default {
  name: 'App',

  components: {
    LayoutHeader,
    LayoutContent,
    LayoutFooter,
    BackToTop,
  },
}
</script>

<style scoped>

</style>
