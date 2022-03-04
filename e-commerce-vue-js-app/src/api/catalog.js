import { join as _join, map as _map, keys as _keys } from 'lodash'
import { client } from '@/api/axios'

export const getCatalog = async (url, page = 1, filters = {}) => {
  console.log(_join(_map(_keys(filters), (key) => `${key}=${filters[key]}`), '&'))
  const requestBody = { categoryUrl: url, page: page, filters: _join(_map(_keys(filters), (key) => `${key}=${filters[key]}`), '&') || '' }
  return await responsePostAsync(client, '/api/catalog/', requestBody)
}

export const getAllFilters = async (url) => {
  const config = { params: { category_url: url } }
  return await responseAsync(client, '/api/catalog/allFilters', config)
}

export const getSearchSuggestions = async (url, searchString) => {
  const requestBody = { categoryUrl: url || '', searchString: searchString || '' }
  return await responsePostAsync(client, '/api/catalog/searchSuggestions', requestBody)
}

const responseAsync = async (client, url, config) => {
  return (await client.get(url, config)).data
}

const responsePostAsync = async (client, url, requestBody) => {
  return (await client.post(url, requestBody)).data
}
