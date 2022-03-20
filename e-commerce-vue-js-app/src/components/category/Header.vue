<template>
  <div id="header">
    <h1>
      {{ categoryName }}<sup>{{ totalFound }}</sup>
    </h1>
  </div>
</template>

<script>
import { mapGetters } from 'vuex'

export default {
  name: 'Header',

  computed: {
    ...mapGetters({
      resultsHeader: 'category/resultsHeader',
      categoryName: 'category/name',
    }),
    totalFound() {
      return this.resultsHeader?.totalFound || '0 товаров'
    },
  },
}
</script>

<style scoped>
#header {
  align-items: center;
  display: flex;
  margin-top: 16px;
  margin-bottom: 16px;
}
#header h1 {
  font-size: 30px;
  font-weight: 700;
  line-height: 38px;
}
#header h1 sup {
  color: #96a3ae;
  font-size: 14px;
  margin-left: 4px;
}
</style>
