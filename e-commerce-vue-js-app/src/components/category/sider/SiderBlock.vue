<template>
  <section>
    <header v-if="title !== ''">
      {{ title }}
    </header>
    <main>
      <slot />
    </main>
  </section>
</template>

<script>
export default {
  name: 'SiderBlock',

  props: {
    title: {
      default: '',
      type: String,
      required: false,
    },
  },
}
</script>

<style scoped>
header{
  color: #001a34;
  cursor: pointer;
  font-size: 16px;
  font-weight: 700;
  line-height: 1.25;
  margin-bottom: 16px;
}
</style>
