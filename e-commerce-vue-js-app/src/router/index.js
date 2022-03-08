import Vue from 'vue'
import VueRouter from 'vue-router'

import Home from '@/views/Home'
import Catalog from '@/views/Catalog'
import Category from '@/views/Category'
import Product from '@/views/Product'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home,
  },
  {
    path: '/catalog',
    name: 'Catalog',
    component: Catalog,
  },
  {
    path: '/category',
    name: 'Category',
    component: Category,
  },
  {
    path: '/product',
    name: 'Product',
    component: Product,
  },
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes,
})

export default router
