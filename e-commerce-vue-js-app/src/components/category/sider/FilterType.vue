<template>
  <div class="filter">
    <template v-if="filter.ftype === 'RESPONSE_FILTER_TYPE_BOOL'">
      <FilterTypeBool
        :key="filter.key"
        :filter="filter"
      />
    </template>
    <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_RADIO'">
      <FilterTypeRadio
        :key="filter.key"
        :filter="filter"
      />
    </template>
    <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_RANGE'">
      <FilterTypeRange
        :key="filter.key"
        :filter="filter"
      />
    </template>
    <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_MULTI'">
      <FilterTypeMulti
        :key="filter.key"
        :filter="filter"
      />
    </template>
    <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_RATING'">
      <FilterTypeRating
        :key="filter.key"
        :filter="filter"
      />
    </template>
    <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_COLOR'">
      <FilterTypeColor
        :key="filter.key"
        :filter="filter"
      />
    </template>
    <template v-else>
      <FilterTypeUndefined
        :key="filter.key"
        :filter="filter"
      />
    </template>
  </div>
</template>

<script>
import FilterTypeBool from '@/components/category/sider/filters/FilterTypeBool'
import FilterTypeRadio from '@/components/category/sider/filters/FilterTypeRadio'
import FilterTypeRange from '@/components/category/sider/filters/FilterTypeRange'
import FilterTypeMulti from '@/components/category/sider/filters/FilterTypeMulti'
import FilterTypeRating from '@/components/category/sider/filters/FilterTypeRating'
import FilterTypeColor from '@/components/category/sider/filters/FilterTypeColor'
import FilterTypeUndefined from '@/components/category/sider/filters/FilterTypeUndefined'

export default {
  name: 'FilterType',

  components: {
    FilterTypeBool,
    FilterTypeRadio,
    FilterTypeRange,
    FilterTypeMulti,
    FilterTypeRating,
    FilterTypeColor,
    FilterTypeUndefined,
  },

  props: {
    filter: {
      type: Object,
      required: true,
    },
  },
}
</script>

<style scoped>

</style>
