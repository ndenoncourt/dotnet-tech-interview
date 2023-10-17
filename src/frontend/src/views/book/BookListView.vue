<script setup lang="ts">
import { useRouter } from 'vue-router'
import { useBookStore } from '@/stores/book'
import BookCover from '@/components/book/BookCover.vue'
import BookCoverAdd from '@/components/book/BookCoverAdd.vue'

const router = useRouter()

const bookStore = useBookStore()
bookStore.fetch()
</script>

<template>
  <div v-if="!bookStore.isLoading" class="flex flex-col gap-4 p-4">
    <div class="flex flex-row flex-wrap gap-4">
      <BookCover
        v-for="book in bookStore.books"
        :key="book.id"
        class="cursor-pointer"
        :title="book.title"
        :author="book.author"
        @click="router.push({ name: 'book_update', params: { id: book.id } })"
      />
      <BookCoverAdd />
    </div>
  </div>
  <div v-else>Chargement...</div>
</template>
