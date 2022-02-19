<template>
  <a-layout-header
    :style="{ position: 'fixed', zIndex: 1, width: '100%' }"
  >
    <a-row type="flex" justify="space-between" align="middle">
      <a-col flex="100px">
        <LayoutHeaderLogo />
      </a-col>
      <a-col :span="4">
        <LayoutHeaderButton />
      </a-col>
      <a-col :span="8">
        <LayoutHeaderAutoComplete />
      </a-col>
      <a-col :span="6">
        <LayoutHeaderActions />
      </a-col>
    </a-row>
  </a-layout-header>
</template>

<script>
import LayoutHeaderLogo from '@/components/common/layout/layoutHeader/LayoutHeaderLogo'
import LayoutHeaderButton from '@/components/common/layout/layoutHeader/LayoutHeaderButton'
import LayoutHeaderAutoComplete from '@/components/common/layout/layoutHeader/LayoutHeaderAutoComplete'
import LayoutHeaderActions from '@/components/common/layout/layoutHeader/LayoutHeaderActions'

export default {
  name: 'LayoutHeader',

  components: {
    LayoutHeaderLogo,
    LayoutHeaderButton,
    LayoutHeaderAutoComplete,
    LayoutHeaderActions,
  },
}
</script>

<style scoped>
header {
  width: 100%;
  display: block;
  min-height: 50px;
  background-color: white;
}
</style>
