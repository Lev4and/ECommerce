<template>
  <SiderBlock
    :title="filter.name"
    :tooltip="filter.shortDesc"
  >
    <a-checkbox-group
      :class="'checkbox-group'"
      :default-value="defaultValues"
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
import { filter as _filter, map as _map } from 'lodash'
import { filter } from '@/services/mixins/filterMixin'
import SiderBlock from '@/components/category/sider/SiderBlock'

export default {
  name: 'FilterTypeColor',

  components: {
    SiderBlock,
  },

  mixins: [filter],

  computed: {
    defaultValues() {
      return _map(_filter(this.filter.values, (value) => value.isActive), (item) => item.key)
    },
  },

  methods: {
    onCheckedValues(checkedValues) {
      if (checkedValues.length > 0) {
        console.log(`${this.filter.key}=${checkedValues.join(',')}`)
      }
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
