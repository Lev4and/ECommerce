import { client } from '@/api/axios'

export const getCatalog = async (url, page = 1) => {
  const config = { params: { category_url: url, p: page } }
  return await responseAsync(client, `/api/catalog/`, config)
}

const responseAsync = async (client, url, config) => {
  return (await client.get(url, config )).data
}