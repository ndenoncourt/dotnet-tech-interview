<script setup lang="ts">
withDefaults(
  defineProps<{
    label: string
    isRequired?: boolean
  }>(),
  {
    isRequired: false
  }
)
</script>

<template>
  <label
    class="flex flex-col items-start gap-1 text-sm font-bold transition-all focus-within:text-green-600"
  >
    {{ label }}
    <slot />
    <span v-if="isRequired" class="text-xs font-normal text-red-500">
      <slot name="validation">Obligatoire</slot>
    </span>
  </label>
</template>
