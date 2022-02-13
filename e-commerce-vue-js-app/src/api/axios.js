import axios from 'axios'
import { resourceAPIUrl } from './config'

export const client = axios.create({
  baseURL: resourceAPIUrl,
  withCredentials: false,
  headers: {
    'Content-Type': 'application/json',
  },
})