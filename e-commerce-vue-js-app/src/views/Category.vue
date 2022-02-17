<template>
  <div id="category">
    <Breadcrumb :category="category" />
    <Header :category="category" />
    <TagList :category="category" />
    <a-layout>
      <a-layout-sider
        width="300"
        style="background: #fff"
      >
        <a-collapse>
          <a-collapse-panel header="Категории">
            <a-tree :tree-data="categories">
              <template
                slot="title"
                slot-scope="{ url, title }"
              >
                <router-link :to="{ name: 'Category', params: { url: url } }">
                  <strong>{{ title }}</strong>
                </router-link>
              </template>
            </a-tree>
          </a-collapse-panel>
          <template v-for="filter in filters">
            <template v-if="filter.ftype === 'RESPONSE_FILTER_TYPE_BOOL'">
              <a-collapse-panel
                :key="filter.key"
                :header="filter.name"
              >
                <a-switch :default-checked="filter.values[0].value" />
              </a-collapse-panel>
            </template>
            <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_RADIO'">
              <a-collapse-panel
                :key="filter.key"
                :header="filter.name"
              >
                <a-radio-group
                  :name="filter.key"
                  :default-value="1"
                >
                  <template v-for="value in filter.values">
                    <a-radio
                      :key="value.key"
                      :value="value.key"
                    >
                      {{
                        value.value
                      }}
                    </a-radio>
                  </template>
                </a-radio-group>
              </a-collapse-panel>
            </template>
            <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_RANGE'">
              <a-collapse-panel
                :key="filter.key"
                :header="filter.name"
              >
                <a-slider
                  range
                  :default-value="[
                    filter.values[0].range.from,
                    filter.values[0].range.to,
                  ]"
                  :min="filter.values[0].range.min"
                  :max="filter.values[0].range.max"
                  :step="filter.values[0].range.step"
                />
                <a-row>
                  <a-col :span="8">
                    <a-input-number
                      :value="filter.values[0].range.from"
                      :min="filter.values[0].range.min"
                      :max="filter.values[0].range.max"
                      :step="filter.values[0].range.step"
                    />
                  </a-col>
                  <a-col :span="8" />
                  <a-col :span="8">
                    <a-input-number
                      :value="filter.values[0].range.to"
                      :min="filter.values[0].range.min"
                      :max="filter.values[0].range.max"
                      :step="filter.values[0].range.step"
                    />
                  </a-col>
                </a-row>
              </a-collapse-panel>
            </template>
            <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_MULTI'">
              <a-collapse-panel
                :key="filter.key"
                :header="filter.name"
              >
                <template v-for="value in filter.values">
                  <a-checkbox
                    :key="value.key"
                    :value="value.value"
                  >
                    {{
                      value.value
                    }}
                  </a-checkbox>
                </template>
              </a-collapse-panel>
            </template>
            <template
              v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_RATING'"
            >
              <a-collapse-panel
                :key="filter.key"
                :header="filter.name"
              >
                <a-switch :default-checked="filter.values[0].value" />
              </a-collapse-panel>
            </template>
            <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_COLOR'">
              <a-collapse-panel
                :key="filter.key"
                :header="filter.name"
              >
                <template v-for="value in filter.values">
                  <a-checkbox
                    :key="value.key"
                    :value="value.value"
                  >
                    {{
                      value.color.name
                    }}
                  </a-checkbox>
                </template>
              </a-collapse-panel>
            </template>
            <template v-else>
              {{ filter.ftype }}
            </template>
          </template>
        </a-collapse>
      </a-layout-sider>
      <a-layout-content
        :style="{
          background: '#fff',
          padding: '24px',
          margin: 0,
          minHeight: '280px',
        }"
      >
        <a-list
          item-layout="vertical"
          size="large"
        >
          <template v-for="product in products">
            <a-list-item :key="product.action.link" />
          </template>
        </a-list>
      </a-layout-content>
    </a-layout>
  </div>
</template>

<script>
import { map as _map } from 'lodash'
import API from '@/api'
import { getWidget } from '@/services/utils/widgetsUtils'
import Breadcrumb from '@/components/category/Breadcrumb'
import Header from '@/components/category/Header'
import TagList from '@/components/category/TagList'

export default {
  name: 'Category',

  components: {
    Breadcrumb,
    Header,
    TagList,
  },

  data: () => ({
    isLoading: false,
    category: null,
    listing: [],
    allFilters: [],
    activeKey: 1,
  }),

  computed: {
    url() {
      return this.$route.params.url
    },
    shared() {
      if (this.category) {
        if (this.category?.shared && this.category?.shared?.length > 0) {
          return JSON.parse(this.category?.shared)
        }
      }
      return null
    },
    widgets() {
      return this.category?.widgetStates
    },
    catalog() {
      return this.shared?.catalog
    },
    currentCategory() {
      return this.catalog?.category
    },
    categoryName() {
      return this.currentCategory?.name || ''
    },
    searchResults() {
      return getWidget(this.widgets, 'searchResultsV2')
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
    products() {
      return this.searchResults?.items || []
    },
  },

  watch: {
    url: {
      handler() {
        this.isLoading = false
        this.loadCategory()
        this.loadAllFilters()
        this.isLoading = true
      },
      deep: true,
      immediate: true,
    },
  },

  methods: {
    async loadCategory() {
      this.category = await API.catalog.getCatalog(this.url, 1)
    },
    async loadAllFilters() {
      this.allFilters = await API.catalog.getAllFilters(this.url, 1)
    },
    mapCategories(categories) {
      if (categories) {
        if (Array.isArray(categories)) {
          return _map(categories, (category) => {
            return {
              url:
                category.info.overrideUrl ||
                `/category/${category.info.urlValue}`,
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

<style scoped>
#category {
  min-height: 100vh;
  margin: 24px auto 0;
}
</style>
