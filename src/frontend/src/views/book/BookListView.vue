<script setup lang="ts">
import { ref, computed } from 'vue'
import { Icon } from '@iconify/vue'
import { useRouter } from 'vue-router'
import { useBookStore } from '@/stores/book'
import BookCover from '@/components/book/BookCover.vue'
import BookCoverAdd from '@/components/book/BookCoverAdd.vue'

const filter = ref('')
const sortAsc = ref(true)
const router = useRouter()

const bookStore = useBookStore()
bookStore.fetch()
const filteredBooks = computed(() =>
  bookStore.books.filter(book =>
    book.title.toLowerCase().includes(filter.value.toLowerCase()) ||
    book.author.toLowerCase().includes(filter.value.toLowerCase())
  )
)
const sortedBooks = computed(() =>
  [...filteredBooks.value].sort((a, b) => {
    return sortAsc.value
      ? a.title.localeCompare(b.title)
      : b.title.localeCompare(a.title)
  })
)
function toggleSortDirection() {
  sortAsc.value = !sortAsc.value
}
</script>

<template>
  <div v-if="!bookStore.isLoading" class="flex flex-col gap-4 p-4">
    <div class="flex flex-row items-center gap-2">
      <input
        v-model="filter"
        type="text"
        placeholder="Filtrer par titre ou auteur"
        class="p-2 border border-green-300 text-green-100 bg-green-200 placeholder-green-100 rounded w-full max-w-sm"
      />
      <button
          @click="toggleSortDirection"
          class="p-2 border border-green-300 bg-green-200 text-green-100 rounded hover:bg-green-300 flex items-center justify-center"
          :title="sortAsc ? 'Tri descendant' : 'Tri ascendant'"
        ><Icon :icon="sortAsc ? 'mdi:sort-alphabetical-ascending' : 'mdi:sort-alphabetical-descending'" class="text-xl" /></button>
    </div>
    <div class="flex flex-row flex-wrap gap-4">
      <BookCover
        v-for="book in sortedBooks"
        :key="book.id"
        class="cursor-pointer"
        :id="book.id"
        :title="book.title"
        :author="book.author"
        :isAvailable="book.isAvailable"
        @click="router.push({ name: 'book_update', params: { id: book.id } })"
      />
      <BookCoverAdd @click="router.push({ name: 'book_create' })" />
    </div>
  </div>
  <div v-else>Chargement...</div>
</template>
