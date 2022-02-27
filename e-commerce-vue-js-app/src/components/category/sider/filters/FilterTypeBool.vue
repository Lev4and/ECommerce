<template>
  <SiderBlock
    :title="filter.name"
    :tooltip="filter.shortDesc"
  >
    <a-switch
      :default-checked="filter.values[0].isActive"
      @change="onChangeChecked"
    />
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

  methods: {
    onChangeChecked(checked) {
      if (checked) {
        console.log(`${this.filter.key}=1`)
      }
    },
  },
}
</script>

<style scoped>

</style>
