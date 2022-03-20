<template>
  <a-select
    style="width: 230px"
    :value="sortingValue"
    @change="onChangeValue"
  >
    <template v-for="item in sortings">
      <a-select-option
        :key="item.id"
        :value="item.urlValue"
      >
        {{ item.name }}
      </a-select-option>
    </template>
  </a-select>
</template>

<script>
import { mapGetters } from 'vuex'
import { find as _find, cloneDeep as _cloneDeep, set as _set, has as _has, omit as _omit } from 'lodash'

export default {
  name: 'Sorting',

  computed: {
    ...mapGetters({
      sortings: 'category/sortings',
    }),
    url() {
      return this.$route.query.url
    },
    query() {
      return _cloneDeep(this.$route.query)
    },
    sorting() {
      return this.query.sorting ? this.query.sorting : ''
    },
    widgets() {
      return this.category?.widgetStates
    },
    sortingValue() {
      return this.sorting ? this.sorting : _find(this.sortings, (value) => value.isActive)?.urlValue
    },
  },

  methods: {
    onChangeValue(value) {
      if (value) {
        if (value !== this.sorting) {
          this.$router.push({ query: _set(this.query, 'sorting', value) })
        }
      } else {
        if (_has(this.query, 'sorting')) {
          this.$router.push({ query: _omit(this.query, 'sorting') })
        }
      }
    },
  },
}
</script>

<style scoped>

</style>
