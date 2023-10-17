import { createRouter, createWebHistory } from 'vue-router'
import Home from '@/views/HomeView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home
    },
    {
      path: '/book',
      name: 'book_list',
      component: () => import('@/views/book/BookListView.vue')
    },
    {
      path: '/book/create',
      name: 'book_create',
      component: () => import('@/views/book/BookCreateView.vue')
    },
    {
      path: '/book/:id',
      name: 'book_update',
      component: () => import('@/views/book/BookUpdateView.vue')
    }
  ]
})

export default router
