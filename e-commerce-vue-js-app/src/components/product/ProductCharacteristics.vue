<template>
  <div id="productCharacteristics">
    <h2>Характеристики</h2>
    <template v-for="section in characteristics">
      <div :key="section.title">
        <h3>{{ section.title }}</h3>
        <div>
          <template v-for="characteristic in section.short">
            <a-row
              :key="characteristic.key"
            >
              <a-col :span="12">
                <span>
                  {{ characteristic.name }}
                  <a-tooltip
                    v-if="characteristic.hintText"
                    slot="suffix"
                  >
                    <template slot="title">
                      <span>{{ characteristic.hintText }}</span>
                    </template>
                    <a-icon
                      type="info-circle"
                      style="color: rgba(0,0,0,.45)"
                    />
                  </a-tooltip>
                </span>
              </a-col>
              <a-col>
                <template v-for="value in characteristic.values">
                  <template v-if="value.link">
                    <router-link
                      :key="value.key"
                      :to="{ name: 'Category', query: { url: value.link, p: 1 } }"
                    >
                      {{ value.text }}
                    </router-link>
                  </template>
                  <template v-else>
                    <span :key="value.key">{{ value.text }}</span>
                  </template>
                </template>
              </a-col>
            </a-row>
          </template>
        </div>
      </div>
    </template>
  </div>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'ProductCharacteristics',

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
    characteristics() {
      return getWidget(this.widgets, 'webCharacteristics')?.characteristics || []
    },
  },
}
</script>

<style scoped>

</style>
