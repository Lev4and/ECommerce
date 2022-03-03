<template>
  <SiderBlock
    :title="filter.name"
    :tooltip="filter.shortDesc"
  >
    <a-radio-group
      :value="value"
      :name="filter.key"
      :class="'radio-group'"
      @change="onCheckedValue"
    >
      <template v-for="filterValue in filter.values">
        <a-radio
          :key="filterValue.key"
          :value="filterValue.key"
        >
          {{ filterValue.value }}
        </a-radio>
      </template>
    </a-radio-group>
  </SiderBlock>
</template>

<script>
import { find as _find } from 'lodash'
import { filter } from '@/services/mixins/filterMixin'
import SiderBlock from '@/components/category/sider/SiderBlock'

export default {
  name: 'FilterTypeRadio',

  components: {
    SiderBlock,
  },

  mixins: [filter],

  computed: {
    value() {
      return this.valueFromRoute ? parseInt(this.valueFromRoute)
        : _find(this.filter.values, (value) => value.isActive)?.key
    },
  },

  methods: {
    onCheckedValue(event) {
      event.target.value ? this.saveFilter(event.target.value) : this.clearFilter()
    },
  },
}
</script>

<style scoped>
div.radio-group {
  display: flex;
  overflow: auto;
  max-height: 200px;
  flex-direction: column;
}
div.radio-group label.ant-radio-wrapper {
  flex: 0 0 auto;
  font-size: 16px;
  line-height: 1.25;
  margin-bottom: 6px;
}
div.radio-group label.ant-radio-wrapper span:not(.ant-radio) {
  color: #001a34;
  flex-basis: auto;
  flex-grow: 1;
  flex-shrink: 1;
  overflow: hidden;
  text-overflow: ellipsis;
}
</style>
