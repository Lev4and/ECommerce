<template>
  <div id="category">
    <a-breadcrumb>
      <a-breadcrumb-item :key="0">
        <router-link :to="{ name: 'Home' }">
          <span>Каталог</span>
        </router-link>
      </a-breadcrumb-item>
      <template v-for="breadCrumb in breadCrumbs">
        <a-breadcrumb-item :key="breadCrumb.link">
          <router-link :to="{ name: 'Category', params: { url: breadCrumb.link } }">
            <span>{{ breadCrumb.text }}</span>
          </router-link>
        </a-breadcrumb-item>
      </template>
      <a-breadcrumb-item :key="url">
        <router-link :to="{ name: 'Category', params: { url: url } }">
          <span>{{ categoryName }}</span>
        </router-link>
      </a-breadcrumb-item>
    </a-breadcrumb>
    <h1>{{ categoryName }}<sup>{{ totalFound }}</sup></h1>
    <template v-for="tag in tagList">
      <a-tag :key="tag.link">{{ tag.name }}</a-tag>
    </template>
    <a-layout>
      <a-layout-sider width="300" style="background: #fff">
        <a-collapse>
          <a-collapse-panel header="Категории">
            <a-tree :treeData="categories">
              <template slot="title" slot-scope="{ url, title }">
                <router-link :to="{ name: 'Category', params: { url: url } }">
                  <strong>{{ title }}</strong>
                </router-link>
              </template>
            </a-tree>
          </a-collapse-panel>
          <template v-for="filter in filters">
            <template v-if="filter.ftype === 'RESPONSE_FILTER_TYPE_BOOL'">
              <a-collapse-panel :key="filter.key" :header="filter.name">
                <a-switch :defaultChecked="filter.values[0].value" />
              </a-collapse-panel>
            </template>
            <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_RADIO'">
              <a-collapse-panel :key="filter.key" :header="filter.name">
                <a-radio-group :name="filter.key" :default-value="1">
                  <template v-for="value in filter.values">
                    <a-radio :key="value.key" :value="value.key">{{ value.value }}</a-radio>
                  </template>
                </a-radio-group>
              </a-collapse-panel>
            </template>
            <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_RANGE'">
              <a-collapse-panel :key="filter.key" :header="filter.name">
                <a-slider range :default-value="[filter.values[0].range.from, filter.values[0].range.to]" :min="filter.values[0].range.min" :max="filter.values[0].range.max" :step="filter.values[0].range.step" />
                <a-row>
                  <a-col :span="8">
                    <a-input-number :value="filter.values[0].range.from" :min="filter.values[0].range.min" :max="filter.values[0].range.max" :step="filter.values[0].range.step" />
                  </a-col>
                  <a-col :span="8">
                    
                  </a-col>
                  <a-col :span="8">
                    <a-input-number :value="filter.values[0].range.to" :min="filter.values[0].range.min" :max="filter.values[0].range.max" :step="filter.values[0].range.step" />
                  </a-col>
                </a-row>
              </a-collapse-panel>
            </template>
            <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_MULTI'">
              <a-collapse-panel :key="filter.key" :header="filter.name">
                <template v-for="value in filter.values">
                  <a-checkbox :key="value.key" :value="value.value">{{ value.value }}</a-checkbox>
                </template>
              </a-collapse-panel>
            </template>
            <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_RATING'">
              <a-collapse-panel :key="filter.key" :header="filter.name">
                <a-switch :defaultChecked="filter.values[0].value" />
              </a-collapse-panel>
            </template>
            <template v-else-if="filter.ftype === 'RESPONSE_FILTER_TYPE_COLOR'">
              <a-collapse-panel :key="filter.key" :header="filter.name">
                <template v-for="value in filter.values">
                  <a-checkbox :key="value.key" :value="value.value">{{ value.color.name }}</a-checkbox>
                </template>
              </a-collapse-panel>
            </template>
            <template v-else>
              {{ filter.ftype }}
            </template>
          </template>
        </a-collapse>
      </a-layout-sider>
      <a-layout-content :style="{ background: '#fff', padding: '24px', margin: 0, minHeight: '280px' }">
        <a-list item-layout="vertical" size="large">
          <template v-for="product in products">
            <a-list-item :key="product.action.link">
              
            </a-list-item>
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

  export default {
    name: 'Category',

    data: () => ({
      isLoading: false,
      category: null,
      listing: [],
      activeKey: 1,
    }),

    watch: {
      url: {
        handler() {
          this.isLoading = false
          this.loadCategory()
          this.isLoading = true
        },
        deep: true,
        immediate: true,
      }
    },

    computed: {
      url() {
        return this.$route.params.url
      },
      shared() {
        if (this.category) {
          if(this.category?.shared && this.category?.shared?.length > 0) {
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
      breadCrumbs() {
        if(this.catalog) {
          return this.catalog?.breadCrumbs || []
        }
        return []
      },
      catalogResultsHeader() {
        return getWidget(this.widgets, 'catalogResultsHeader')
      },
      searchResults() {
        return getWidget(this.widgets, 'searchResultsV2')
      },
      searchResultsFilters() {
        return getWidget(this.widgets, 'searchResultsFilters')
      },
      totalFound() {
        return this.catalogResultsHeader?.totalFound || '0 товаров'
      },
      tagList() {
        return getWidget(this.widgets, 'tagList')?.items || []
      },
      categories() {
        return this.mapCategories(this.searchResultsFilters?.categories)
      },
      filters() {
        console.log(this.searchResultsFilters?.filters || [])
        return this.searchResultsFilters?.filters || []
      },
      products() {
        console.log(this.searchResults?.items || [])
        return this.searchResults?.items || []
      },
    },

    methods: {
      async loadCategory() {
        this.category = await API.catalog.getCatalog(this.url, 1)
      },
      mapCategories(categories) {
        if (categories) {
          if (Array.isArray(categories)) {
            return _map(categories, (category) => { 
              return {
                url: category.info.overrideUrl || `/category/${category.info.urlValue}`,
                title: category.info.name,
                scopedSlots: { title: 'title' },
                children: this.mapCategories(category.categories)
              }
            })
          }
        }
        return []
      },
    }
  }
</script>

<style scoped>
  #category{
    min-height: 100vh;
  }
</style>
