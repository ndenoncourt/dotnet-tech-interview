<script setup lang="ts">
import BookCoverBase from './BookCoverBase.vue'

defineProps<{
  title: string
  author: string
}>()
</script>

<template>
  <BookCoverBase>
    <span class="text-xl font-bold">{{ title }}</span>
    <span class="text-sm text-white/50">{{ author }}</span>
  </BookCoverBase>
</template>
