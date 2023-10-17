<script setup lang="ts">
defineProps<{
  modelValue: string
}>()

const emit = defineEmits<{
  (e: 'update:modelValue', modelValue: string): void
}>()
</script>

<template>
  <input
    class="p-1 font-normal text-black transition-all border rounded outline-none focus:border-green-500 focus:ring-2 ring-green-500"
    v-bind="$attrs"
    type="string"
    :value="modelValue"
    @input="emit('update:modelValue', ($event.target as HTMLInputElement).value as string)"
  />
</template>
