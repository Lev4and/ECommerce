<template>
  <div id="productBreadcrumb">
    <a-breadcrumb>
      <a-breadcrumb-item :key="0">
        <router-link :to="{ name: 'Catalog' }">
          <span>Каталог</span>
        </router-link>
      </a-breadcrumb-item>
      <template v-for="breadCrumb in breadCrumbs">
        <a-breadcrumb-item :key="breadCrumb.link">
          <router-link
            :to="{ name: 'Category', query: { url: breadCrumb.link } }"
          >
            <span>{{ breadCrumb.text }}</span>
          </router-link>
        </a-breadcrumb-item>
      </template>
    </a-breadcrumb>
  </div>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'ProductBreadcrumb',

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
    breadCrumbs() {
      return getWidget(this.widgets, 'breadCrumbsPdp')?.breadCrumbs || []
    },
  },
}
</script>

<style scoped>
#productBreadcrumb {
  display: flex;
  align-items: center;
  flex-wrap: wrap;
  font-size: 14px;
  margin: 8px 0 6px;
  justify-content: flex-start;
  min-height: 26px;
}
#productBreadcrumb .ant-breadcrumb .ant-breadcrumb-link a {
  color: #005bff !important;
  display: inline-block !important;
}
</style>
