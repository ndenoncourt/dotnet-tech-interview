<script setup lang="ts">
import BookCoverBase from './BookCoverBase.vue'

defineProps<{
  title: string
  author: string
  isAvailable: boolean
}>()
</script>

<template>
  <BookCoverBase>
    <span class="font-bold text-ellipsis line-clamp-3" :title="title">{{ title }}</span>
    <span class="text-sm text-white/50 line-clamp-1" :title="author">{{ author }}</span>
    <span class="text-sm text-green-100 line-clamp-1" v-if="isAvailable">Disponible</span>
    <span class="text-sm text-red-100 line-clamp-1" v-else="isAvailable">Non disponible</span>
  </BookCoverBase>
</template>
