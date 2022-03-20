import { cloneDeep as _cloneDeep } from 'lodash'
import { getWidget } from '@/services/utils/widgetsUtils'

const defaultState = {
  category: null,
  widgets: null,
  activeFilters: [],
  shared: null,
  catalog: null,
  searchResults: [],
  semanticText: '',
  sortings: [],
  breadCrumbs: [],
  name: '',
  resultsHeader: null,
  resultsFilters: null,
  tagList: null,
  tags: [],
}

const state = _cloneDeep(defaultState)

const mutations = {
  setWidgets(state) {
    state.widgets = state.category.widgetStates
  },
  setActiveFilters(state) {
    state.activeFilters = getWidget(state.widgets, 'searchResultsFiltersActive')?.activeFilters || []
  },
  setShared(state) {
    if (state.category) {
      if (state.category?.shared?.length > 0) {
        state.shared = JSON.parse(state.category?.shared)
      }
    }
  },
  setCatalog(state) {
    state.catalog = state.shared?.catalog
  },
  setSearchResults(state) {
    state.searchResults = getWidget(state.widgets, 'searchResultsV2')?.items || []
  },
  setSemanticText(state) {
    state.semanticText = getWidget(state.widgets, 'semanticText')?.semantic_text || ''
  },
  setSortings(state) {
    state.sortings = getWidget(state.widgets, 'searchResultsSort')?.sortings || []
  },
  setBreadCrumbs(state) {
    state.breadCrumbs = state.catalog?.breadCrumbs || []
  },
  setName(state) {
    state.name = state.catalog?.category?.name || ''
  },
  setResultsHeader(state) {
    state.resultsHeader = getWidget(state.widgets, 'catalogResultsHeader')
  },
  setResultsFilters(state) {
    state.resultsFilters = getWidget(state.widgets, 'searchResultsFilters')
  },
  setTagList(state) {
    state.tagList = getWidget(state.widgets, 'tagList')
  },
  setTags(state) {
    state.tags = state.tagList?.items || []
  },
}

const getters = {
  category(state) {
    return state.category
  },
  widgets(state) {
    return state.widgets
  },
  activeFilters(state) {
    return state.activeFilters
  },
  shared(state) {
    return state.shared
  },
  catalog(state) {
    return state.catalog
  },
  searchResults(state) {
    return state.searchResults
  },
  semanticText(state) {
    return state.semanticText
  },
  sortings(state) {
    return state.sortings
  },
  breadCrumbs(state) {
    return state.breadCrumbs
  },
  name(state) {
    return state.name
  },
  resultsHeader(state) {
    return state.resultsHeader
  },
  resultsFilters(state) {
    return state.resultsFilters
  },
  tagList(state) {
    return state.tagList
  },
  tags(state) {
    return state.tags
  },
}

const actions = {
  async init({ state, commit }, category) {
    state.category = category
    commit('setShared')
    commit('setCatalog')
    commit('setWidgets')
    commit('setActiveFilters')
    commit('setSearchResults')
    commit('setSemanticText')
    commit('setSortings')
    commit('setBreadCrumbs')
    commit('setName')
    commit('setResultsHeader')
    commit('setResultsFilters')
    commit('setTagList')
    commit('setTags')
  },
}

export default {
  namespaced: true,
  state,
  getters,
  mutations,
  actions,
}
