<template>
  <SiderBlock :title="filter.name">
    <strong>{{ filter.ftype }}</strong>
  </SiderBlock>
</template>

<script>
import { filter } from '@/services/mixins/filterMixin'
import SiderBlock from '@/components/category/sider/SiderBlock'

export default {
  name: 'FilterTypeUndefined',

  components: {
    SiderBlock,
  },

  mixins: [filter],
}
</script>

<style scoped>

</style>
