import { client } from '@/api/axios'
import { responseGetAsync } from '@/services/utils/responseUtils.js'

export const getCategory = async () => {
  return await responseGetAsync(client, '/api/category/', null)
}

export const getCategoryById = async (id) => {
  return await responseGetAsync(client, `/api/category/${id}`, null)
}
