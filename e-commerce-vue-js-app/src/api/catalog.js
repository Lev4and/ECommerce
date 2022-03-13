import { join as _join, map as _map, keys as _keys } from 'lodash'
import { client } from '@/api/axios'
import { responsePostAsync } from '@/services/utils/responseUtils.js'

export const getCatalog = async (url, page = 1, filters = {}, sorting = '') => {
  const requestBody = {
    page: page,
    sorting: sorting,
    categoryUrl: url,
    filters: _join(_map(_keys(filters), (key) => `${key}=${filters[key]}`), '&') || '',
  }
  return await responsePostAsync(client, '/api/catalog/', requestBody)
}

export const getAllFilters = async (url, filters = {}) => {
  const requestBody = {
    categoryUrl: url,
    filters: _join(_map(_keys(filters), (key) => `${key}=${filters[key]}`), '&') || '',
  }
  return await responsePostAsync(client, '/api/catalog/allFilters', requestBody)
}

export const getSearchSuggestions = async (url, searchString) => {
  const requestBody = { categoryUrl: url || '', searchString: searchString || '' }
  return await responsePostAsync(client, '/api/catalog/searchSuggestions', requestBody)
}
