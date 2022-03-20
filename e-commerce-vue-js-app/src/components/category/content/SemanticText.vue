<!-- eslint-disable vue/no-v-html -->
<template>
  <div
    id="semanticText"
    v-html="semanticText"
  />
</template>

<script>
import { mapGetters } from 'vuex'

export default {
  name: 'SemanticText',

  computed: {
    ...mapGetters({
      semanticText: 'category/semanticText',
    }),
  },
}
</script>

<style scoped>

</style>
