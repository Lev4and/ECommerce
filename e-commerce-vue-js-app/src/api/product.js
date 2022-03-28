import { client } from '@/api/axios'
import { responseGetAsync } from '@/services/utils/responseUtils.js'

export const getProduct = async (url) => {
  const config = { params: { url: url } }
  return await responseGetAsync(client, '/api/product/', config)
}

export const getCharacteristics = async (url) => {
  const config = { params: { url: url } }
  return await responseGetAsync(client, '/api/product/characteristics/', config)
}

export const getReviews = async (url) => {
  const config = { params: { url: url } }
  return await responseGetAsync(client, '/api/product/reviews/', config)
}

export const getReviewsListing = async (url, asyncData, page) => {
  const config = { params: { url: url, async_data: asyncData, p: page } }
  return await responseGetAsync(client, '/api/product/reviews/list/', config)
}

export const getCommentsByReview = async (reviewId, limit, offset) => {
  const config = { params: { reviewId: reviewId, limit: limit, offset: offset } }
  return await responseGetAsync(client, '/api/product/reviews/comments/', config)
}
