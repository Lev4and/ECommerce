import { join as _join, map as _map, keys as _keys } from 'lodash'
import { client } from '@/api/axios'
import { responseGetAsync, responsePostAsync } from '@/services/utils/responseUtils.js'

export const getCatalog = async (url, page = 1, filters = {}, sorting = '') => {
  const requestBody = {
    page: page,
    sorting: sorting,
    categoryUrl: url,
    filters: _join(_map(_keys(filters), (key) => `${key}=${filters[key]}`), '&') || '',
  }
  return await responsePostAsync(client, '/api/catalog/', requestBody)
}

export const getAllFilters = async (url) => {
  const config = { params: { category_url: url } }
  return await responseGetAsync(client, '/api/catalog/allFilters', config)
}

export const getSearchSuggestions = async (url, searchString) => {
  const requestBody = { categoryUrl: url || '', searchString: searchString || '' }
  return await responsePostAsync(client, '/api/catalog/searchSuggestions', requestBody)
}
