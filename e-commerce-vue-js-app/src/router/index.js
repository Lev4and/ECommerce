import Vue from 'vue'
import VueRouter from 'vue-router'

import Home from '@/views/Home'
import Category from '@/views/Category'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home,
  },
  {
    path: '/category?url=:url',
    name: 'Category',
    component: Category,
  },
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes,
})

export default router
