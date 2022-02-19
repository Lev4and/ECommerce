<template>
  <SiderBlock :title="filter.name">
    <a-slider
      range
      :min="filter.values[0].range.min"
      :max="filter.values[0].range.max"
      :step="0.1"
      :default-value="[filter.values[0].range.from, filter.values[0].range.to]"
    />
    <a-row>
      <a-col :span="8">
        <a-input-number
          :min="filter.values[0].range.min"
          :max="filter.values[0].range.max"
          :step="0.1"
          :default-value="filter.values[0].range.from"
        />
      </a-col>
      <a-col :span="8" />
      <a-col :span="8">
        <a-input-number
          :min="filter.values[0].range.min"
          :max="filter.values[0].range.max"
          :step="0.1"
          :default-value="filter.values[0].range.to"
        />
      </a-col>
    </a-row>
  </SiderBlock>
</template>

<script>
import { filter } from '@/services/mixins/filterMixin'
import SiderBlock from '@/components/category/sider/SiderBlock'

export default {
  name: 'FilterTypeRange',

  components: {
    SiderBlock,
  },

  mixins: [filter],
}
</script>

<style scoped>

</style>
