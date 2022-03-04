<template>
  <SiderBlock>
    <div class="button-group">
      <a-button @click="showAllFilters">
        Все фильтры
      </a-button>
      <a-button
        type="danger"
        @click="resetFilters"
      >
        Сбросить
      </a-button>
      <a-button
        type="primary"
        @click="applyFilters"
      >
        Применить
      </a-button>
    </div>
  </SiderBlock>
</template>

<script>
import EventBus from '@/services/eventBus.js'
import SiderBlock from '@/components/category/sider/SiderBlock'

export default {
  name: 'BlockActions',

  components: {
    SiderBlock,
  },

  methods: {
    showAllFilters() {
      EventBus.$emit('show-all-filters')
    },
    applyFilters() {
      EventBus.$emit('apply-filters')
    },
    resetFilters() {
      EventBus.$emit('reset-filters')
    },
  },
}
</script>

<style scoped>
div.button-group {
  align-items: flex-start;
  display: flex;
  flex-flow: column;
}
div.button-group button.ant-btn {
  width: 100%;
  flex: 0 0 auto;
  font-size: 16px;
  line-height: 1.25;
  margin-left: 0px;
  margin-bottom: 6px;
}
</style>
