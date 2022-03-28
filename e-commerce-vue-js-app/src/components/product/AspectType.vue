<template>
  <div id="aspectType">
    <template v-if="aspect.type === 'textBar' || aspect.type === 'textBarIcon' || aspect.type === 'carousel'">
      <AspectTypeTextBar :aspect="aspect" />
    </template>
    <template v-else-if="aspect.type === 'colors' || aspect.type === 'colorsMix'">
      <AspectTypeColors :aspect="aspect" />
    </template>
    <template v-else-if="aspect.type === 'sizes'">
      <AspectTypeSizes :aspect="aspect" />
    </template>
    <template v-else>
      <AspectTypeUndefined :aspect="aspect" />
    </template>
  </div>
</template>

<script>
import AspectTypeTextBar from '@/components/product/aspects/AspectTypeTextBar'
import AspectTypeColors from '@/components/product/aspects/AspectTypeColors'
import AspectTypeSizes from '@/components/product/aspects/AspectTypeSizes'
import AspectTypeUndefined from '@/components/product/aspects/AspectTypeUndefined'

export default {
  name: 'AspectType',

  components: {
    AspectTypeTextBar,
    AspectTypeColors,
    AspectTypeSizes,
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
