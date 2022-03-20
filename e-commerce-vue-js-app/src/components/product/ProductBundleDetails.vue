<template>
  <div id="productBundleDetails">
    <a-row
      type="flex"
      align="middle"
      :gutter="[16,0]"
    >
      <a-col>
        <h2>{{ header }}</h2>
      </a-col>
      <a-col>
        <a-icon type="clock-circle" /> до {{ deadlineTimestamp }}
      </a-col>
    </a-row>
  </div>
</template>

<script>
import moment from 'moment'
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'ProductBundleDetails',

  props: {
    product: {
      type: Object,
      default: null,
      required: false,
    },
  },

  computed: {
    widgets() {
      return this.product?.widgetStates
    },
    bundleDetails() {
      return getWidget(this.widgets, 'bundleDetails')
    },
    bundleHeader() {
      return this.bundleDetails?.bundleHeader
    },
    header() {
      return this.bundleHeader?.title?.text
    },
    deadlineTimestamp() {
      return moment(this.bundleHeader?.timer?.deadlineTimestamp).format('DD.MM.YYYY HH:mm:ss')
    },
  },
}
</script>

<style scoped>

</style>
