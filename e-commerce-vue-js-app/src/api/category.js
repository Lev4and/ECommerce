import { client } from '@/api/axios'

export const getCategory = async () => {
  return await responseAsync(client, '/api/category/', null)
}

export const getCategoryById = async (id) => {
  return await responseAsync(client, `/api/category/${id}`, null)
}

const responseAsync = async (client, url, config) => {
  return (await client.get(url, config )).data
}