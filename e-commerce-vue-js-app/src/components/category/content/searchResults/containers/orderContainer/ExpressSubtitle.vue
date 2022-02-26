<template>
  <div
    class="express-subtitle"
    v-html="expressSubtitle"
  />
</template>

<script>
export default {
  name: 'ExpressSubtitle',

  props: {
    item: {
      type: Object,
      required: true,
    },
  },

  computed: {
    expressSubtitle() {
      return this.item.multiButton?.expressSubtitle?.textAtomWithIcon?.text
    },
  },
}
</script>
