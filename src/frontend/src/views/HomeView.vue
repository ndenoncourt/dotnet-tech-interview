<script setup lang="ts">
import { Icon } from '@iconify/vue'
import Button, { ButtonStylingMode } from '@/components/Button.vue'
import { useRouter } from 'vue-router'

const router = useRouter()
</script>

<template>
  <div
    class="flex flex-col items-center justify-center flex-1 w-full min-h-full text-green-800 bg-green-200"
  >
    <Icon class="mb-4 text-6xl animate-bounce" icon="lucide:party-popper" />
    <span class="text-3xl font-bold">Ça fonctionne!</span>
    <p>Bienvenue dans Book Manager!</p>
    <ul class="mt-4 divide-y divide-green-800/25">
      <li class="py-1">
        Si tu as besoin d'icônes,
        <a
          class="text-green-600 underline"
          href="https://icones.js.org/collection/all"
          target="_blank"
          >c'est par ici !</a
        >
      </li>
    </ul>
    <div class="h-4" />
    <Button :styling-mode="ButtonStylingMode.Primary" @click="router.push({ name: 'book_list' })">
      Consulter les livres
    </Button>
  </div>
</template>
