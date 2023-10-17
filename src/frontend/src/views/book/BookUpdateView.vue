<script setup lang="ts">
import { useBookStore, type Book } from '@/stores/book'
import { computed, onMounted, ref } from 'vue'
import { useRoute, useRouter } from 'vue-router'
import BookForm from '@/components/book/BookForm.vue'
import Button, { ButtonStylingMode } from '@/components/Button.vue'

const route = useRoute()
const id = route.params.id as string

const bookStore = useBookStore()
const book = ref<Book>()

const router = useRouter()

const isValid = computed(
  () => book.value && book.value.title.trim().length > 0 && book.value.author.trim().length > 0
)

onMounted(async () => {
  try {
    await bookStore.fetch()
    book.value = bookStore.books.find((x) => x.id === parseInt(id))
    if (!book.value) {
      throw 'Book not found'
    }
  } catch {
    return router.push({ name: 'book_list' })
  }
})

async function handleUpdate() {
  if (!book.value) {
    throw 'Book not found'
  }
  await bookStore.update(book.value)
  router.push({ name: 'book_list' })
}
</script>

<template>
  <div class="flex flex-col items-center p-4">
    <div class="flex flex-col w-full max-w-lg gap-4 p-4 bg-white rounded shadow-xl">
      <span class="text-xl font-bold">Information du livre</span>
      <div class="flex flex-row gap-4">
        <BookForm v-if="book" v-model="book" />
      </div>
      <Button :styling-mode="ButtonStylingMode.Primary" :disabled="!isValid" @click="handleUpdate()"
        >Save</Button
      >
    </div>
  </div>
</template>
