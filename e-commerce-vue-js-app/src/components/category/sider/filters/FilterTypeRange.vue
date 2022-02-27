<template>
  <SiderBlock
    :title="filter.name"
    :tooltip="filter.shortDesc"
  >
    <a-slider
      v-model="sliderRange"
      range
      :min="range.min"
      :max="range.max"
      :step="0.1"
      @change="onChangeRangeSlider"
    />
    <a-row>
      <a-col :span="8">
        <a-input-number
          v-model="range.from"
          :min="range.min"
          :max="range.max"
          :step="0.1"
          @change="onChangeRangeFrom"
        />
      </a-col>
      <a-col :span="8" />
      <a-col :span="8">
        <a-input-number
          v-model="range.to"
          :min="range.min"
          :max="range.max"
          :step="0.1"
          @change="onChangeRangeTo"
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

  data: () => ({
    range: null,
    sliderRange: [],
  }),

  watch: {
    range: {
      handler() {
        console.log(`${this.filter.key}=${this.range?.from || 0};${this.range?.to || 0}`)
      },
      deep: true,
      immediate: true,
    },
  },

  created() {
    this.range = this.filter.values[0].range
    this.sliderRange = [this.range.from, this.range.to]
  },

  methods: {
    onChangeRangeSlider(value) {
      this.range.from = value[0]
      this.range.to = value[1]
    },
    onChangeRangeFrom(value) {
      this.sliderRange = [value, this.range.to]
    },
    onChangeRangeTo(value) {
      this.sliderRange = [this.range.from, value]
    },
  },
}
</script>

<style scoped>

</style>
