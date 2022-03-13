<template>
  <SiderBlock
    :title="filter.name"
    :tooltip="filter.shortDesc"
  >
    <a-switch
      :checked="checked"
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

  computed: {
    checked() {
      return Boolean(this.valueFromRoute)
    },
  },

  methods: {
    onChangeChecked(checked) {
      checked ? this.saveFilter(1) : this.clearFilter()
    },
  },
}
</script>

<style scoped>

</style>
