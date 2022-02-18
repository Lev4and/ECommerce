<template>
  <SiderBlock :title="filter.name">
    <a-switch :default-checked="filter.values[0].value" />
  </SiderBlock>
</template>

<script>
import { filter } from '@/services/mixins/filterMixin'
import SiderBlock from '@/components/category/sider/SiderBlock'

export default {
  name: 'FilterTypeBool',

  components: {
    SiderBlock,
  },

  mixins: [filter],
}
</script>

<style scoped>

</style>
