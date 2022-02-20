import { client } from '@/api/axios'

export const getCatalog = async (url, page = 1) => {
  const config = { params: { category_url: url, p: page } }
  return await responseAsync(client, '/api/catalog/', config)
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
