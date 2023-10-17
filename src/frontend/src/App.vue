<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import { Icon } from '@iconify/vue'
</script>

<template>
  <div class="flex flex-col min-h-screen bg-green-200">
    <!-- Header -->
    <header class="p-4">
      <nav class="flex flex-row justify-between">
        <RouterLink to="/">
          <div class="flex flex-row items-center gap-2 font-bold text-green-800">
            <Icon icon="ic:twotone-menu-book" />
            <span>Book Manager</span>
          </div>
        </RouterLink>

        <div class="flex flex-row gap-2">
          <RouterLink class="text-green-600" to="/book">Livres</RouterLink>
        </div>
      </nav>
    </header>

    <!-- App content -->
    <RouterView />
  </div>
</template>
