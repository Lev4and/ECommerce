<template>
  <div id="aspectType">
    <template v-if="aspect.type === 'textBar'">
      <AspectTypeTextBar :aspect="aspect" />
    </template>
    <template v-else-if="aspect.type === 'colors'">
      <AspectTypeColors :aspect="aspect" />
    </template>
    <template v-else>
      <AspectTypeUndefined :aspect="aspect" />
    </template>
  </div>
</template>

<script>
import AspectTypeTextBar from '@/components/product/aspects/AspectTypeTextBar'
import AspectTypeColors from '@/components/product/aspects/AspectTypeColors'
import AspectTypeUndefined from '@/components/product/aspects/AspectTypeUndefined'

export default {
  name: 'AspectType',

  components: {
    AspectTypeTextBar,
    AspectTypeColors,
    AspectTypeUndefined,
  },

  props: {
    aspect: {
      type: Object,
      default: null,
      required: false,
    },
  },
}
</script>

<style scoped>

</style>
