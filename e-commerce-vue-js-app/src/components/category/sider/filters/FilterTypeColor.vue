<template>
  <SiderBlock
    :title="filter.name"
    :tooltip="filter.shortDesc"
  >
    <a-checkbox-group
      :value="values"
      :class="'checkbox-group'"
      @change="onCheckedValues"
    >
      <template v-for="value in filter.values">
        <a-checkbox
          :key="value.key"
          :value="value.key"
        >
          {{ value.color.name }}
        </a-checkbox>
      </template>
    </a-checkbox-group>
  </SiderBlock>
</template>

<script>
import { map as _map } from 'lodash'
import { filter } from '@/services/mixins/filterMixin'
import SiderBlock from '@/components/category/sider/SiderBlock'

export default {
  name: 'FilterTypeColor',

  components: {
    SiderBlock,
  },

  mixins: [filter],

  computed: {
    values() {
      return _map(this.valueFromRoute.split(','), (value) => parseInt(value))
    },
  },

  methods: {
    onCheckedValues(checkedValues) {
      checkedValues.length > 0 ? this.saveFilter(checkedValues.join(',')) : this.clearFilter()
    },
  },
}
</script>

<style scoped>
div.checkbox-group {
  display: flex;
  overflow: auto;
  flex-flow: column;
  max-height: 200px;
  align-items: flex-start;
}
div.checkbox-group label.ant-checkbox-wrapper {
  flex: 0 0 auto;
  font-size: 16px;
  line-height: 1.25;
  margin-left: 0px;
  margin-bottom: 6px;
}
div.checkbox-group label.ant-checkbox-wrapper span:not(.ant-checkbox) {
  color: #001a34;
  flex-basis: auto;
  flex-grow: 1;
  flex-shrink: 1;
  overflow: hidden;
  text-overflow: ellipsis;
}
</style>
