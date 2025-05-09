<script setup lang="ts">
import { Icon } from '@iconify/vue'
import { useBookStore, type Book } from '@/stores/book'
import BookCoverBase from './BookCoverBase.vue'

const bookStore = useBookStore()
bookStore.fetch()

const props = defineProps<{
  id: number
  title: string
  author: string
  isAvailable: boolean
}>()

async function handleDelete() {
  const id = await bookStore.remove(props.id)
}
</script>

<template>
  <BookCoverBase class="relative">
    <button
      @click.stop="handleDelete"
      class="absolute bottom-1 right-1 text-green-300 hover:text-green-500 text-base"
      title="Supprimer"><Icon icon="material-symbols:delete" /></button>
    <span class="font-bold text-ellipsis line-clamp-3" :title="title">{{ title }}</span>
    <span class="text-sm text-white/50 line-clamp-1" :title="author">{{ author }}</span>
    <span class="text-sm text-green-100 line-clamp-1" v-if="isAvailable">Disponible</span>
    <span class="text-sm text-red-100 line-clamp-1" v-else="isAvailable">Non disponible</span>
  </BookCoverBase>
</template>
