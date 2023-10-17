<script setup lang="ts">
import type { Book } from '@/stores/book'
import InputBase from '@/components/input/InputBase.vue'
import Field from '@/components/field/Field.vue'

withDefaults(
  defineProps<{
    modelValue: Book
    isIdChangeEnabled?: boolean
  }>(),
  {
    isIdChangeEnabled: false
  }
)
</script>

<template>
  <Field v-if="isIdChangeEnabled" label="Identifiant" is-required class="flex-1">
    <InputBase
      class="w-full"
      type="number"
      min="1"
      :model-value="modelValue.id.toString()"
      @update:model-value="(id) => emit('update:modelValue', { ...modelValue, id: parseInt(id) })"
    />
    <template #validation>Obligatoire, unique</template>
  </Field>
  <Field label="Titre" is-required class="flex-1">
    <InputBase
      class="w-full"
      type="text"
      :model-value="modelValue.title"
      @update:model-value="(title) => (modelValue.title = title)"
    />
  </Field>
  <Field label="Auteur" is-required class="flex-1">
    <InputBase
      class="w-full"
      type="text"
      :model-value="modelValue.author"
      @update:model-value="(author) => (modelValue.author = author)"
    />
  </Field>
</template>
