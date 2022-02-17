<template>
  <div id="sider">
    <a-layout-sider width="300" style="background: #fff">
      <section>
        <header>Категории</header>
        <main>
          <a-tree :tree-data="categories">
            <template slot="title" slot-scope="{ url, title }">
              <router-link :to="{ name: 'Category', params: { url: url } }">
                <strong>{{ title }}</strong>
              </router-link>
            </template>
          </a-tree>
        </main>
      </section>
      <template v-for="filter in filters">
        <section :key="filter.key">
          <header>{{ filter.name }}</header>
          <main>
            <template v-if="filter.ftype === 'RESPONSE_FILTER_TYPE_BOOL'">
              <a-switch :default-checked="filter.values[0].value" />
            </template>
            <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_RADIO'">
              <a-radio-group :name="filter.key" :default-value="1">
                <template v-for="value in filter.values">
                  <a-radio :key="value.key" :value="value.key">{{ value.value }}</a-radio>
                </template>
              </a-radio-group>
            </template>
            <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_RANGE'">
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
                    :value="filter.values[0].range.from"
                  />
                </a-col>
                <a-col :span="8" />
                <a-col :span="8">
                  <a-input-number
                    :min="filter.values[0].range.min"
                    :max="filter.values[0].range.max"
                    :step="0.1"
                    :value="filter.values[0].range.to"
                  />
                </a-col>
              </a-row>
            </template>
            <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_MULTI'">
              <div class="checkbox-group">
                <template v-for="value in filter.values">
                  <a-checkbox :key="value.key" :value="value.value" :checked="false">{{ value.value }}</a-checkbox>
                </template>
              </div>
            </template>
            <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_RATING'">
              <a-switch :default-checked="filter.values[0].value" />
            </template>
            <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_COLOR'">
              <div class="checkbox-group">
                <template v-for="value in filter.values">
                  <a-checkbox :key="value.key" :value="value.value" :checked="false">{{ value.color.name }}</a-checkbox>
                </template>
              </div>
            </template>
            <template v-else>
              {{ filter.ftype }}
            </template>
          </main>
        </section>
      </template>
      <section>
        <main>
          <div class="button-group">
            <a-button>Все фильтры</a-button>
            <a-button type="danger">Сбросить</a-button>
            <a-button type="primary">Применить</a-button>
          </div>
        </main>
      </section>
    </a-layout-sider>
  </div>
</template>

<script>
import { map as _map } from 'lodash'
import API from '@/api'
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'Sider',

  props: {
    category: Object,
  },

  computed: {
    url() {
      return this.$route.params.url
    },
    widgets() {
      return this.category?.widgetStates
    },
    searchResultsFilters() {
      return getWidget(this.widgets, 'searchResultsFilters')
    },
    categories() {
      return this.mapCategories(this.searchResultsFilters?.categories)
    },
    filters() {
      return this.searchResultsFilters?.filters || []
    },
  },

  watch: {
    category: {
      handler() {
        this.isLoading = false
        this.loadAllFilters()
        this.isLoading = true
      },
      deep: true,
      immediate: true,
    },
  },

  methods: {
    async loadAllFilters() {
      this.allFilters = await API.catalog.getAllFilters(this.url, 1)
    },
    mapCategories(categories) {
      if (categories) {
        if (Array.isArray(categories)) {
          return _map(categories, (category) => {
            return {
              url: category.info.overrideUrl || `/category/${category.info.urlValue}`,
              title: category.info.name,
              scopedSlots: { title: 'title' },
              children: this.mapCategories(category.categories),
            }
          })
        }
      }
      return []
    },
  },
}
</script>

<style>
#sider aside.ant-layout-sider div.ant-layout-sider-children{
  padding: 10px;
}
#sider aside.ant-layout-sider div.ant-layout-sider-children section{
  margin: 12px 0;
}
#sider aside.ant-layout-sider div.ant-layout-sider-children section:first-child{
  margin: 0 0 12px 0;
}
#sider aside.ant-layout-sider div.ant-layout-sider-children section header{
  color: #001a34;
  cursor: pointer;
  font-size: 16px;
  font-weight: 700;
  line-height: 1.25;
  margin-bottom: 16px;
}
#sider aside.ant-layout-sider div.ant-layout-sider-children section main div.ant-radio-group{
  display: flex;
  flex-direction: column;
}
#sider aside.ant-layout-sider div.ant-layout-sider-children section main div.ant-radio-group label.ant-radio-wrapper{
  flex: 0 0 auto;
  font-size: 16px;
  line-height: 1.25;
  margin-bottom: 6px;
}
#sider aside.ant-layout-sider div.ant-layout-sider-children section main div.ant-radio-group label.ant-radio-wrapper span:not(.ant-radio){
  color: #001a34;
  flex-basis: auto;
  flex-grow: 1;
  flex-shrink: 1;
  overflow: hidden;
  text-overflow: ellipsis;
}
#sider aside.ant-layout-sider div.ant-layout-sider-children section main div.checkbox-group{
  align-items: flex-start;
  display: flex;
  flex-flow: column;
}
#sider aside.ant-layout-sider div.ant-layout-sider-children section main div.checkbox-group label.ant-checkbox-wrapper{
  flex: 0 0 auto;
  font-size: 16px;
  line-height: 1.25;
  margin-left: 0px;
  margin-bottom: 6px;
}
#sider aside.ant-layout-sider div.ant-layout-sider-children section main div.checkbox-group label.ant-checkbox-wrapper span:not(.ant-checkbox){
  color: #001a34;
  flex-basis: auto;
  flex-grow: 1;
  flex-shrink: 1;
  overflow: hidden;
  text-overflow: ellipsis;
}
#sider aside.ant-layout-sider div.ant-layout-sider-children section main div.button-group{
  align-items: flex-start;
  display: flex;
  flex-flow: column;
}
#sider aside.ant-layout-sider div.ant-layout-sider-children section main div.button-group button.ant-btn{
  width: 100%;
  flex: 0 0 auto;
  font-size: 16px;
  line-height: 1.25;
  margin-left: 0px;
  margin-bottom: 6px;
}
</style>
