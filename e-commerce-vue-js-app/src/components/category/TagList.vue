<template>
  <div v-if="tagList.length > 0" id="tagList">
    <template v-for="tag in tagList">
      <a-tag
        :key="tag.link"
        :class="'tag'"
      >
        {{ tag.name }}
      </a-tag>
    </template>
  </div>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'TagList',

  props: {
    category: {
      type: Object,
      required: false,
    },
  },

  computed: {
    widgets() {
      return this.category?.widgetStates
    },
    tagList() {
      return getWidget(this.widgets, 'tagList')?.items || []
    },
  },
}
</script>

<style scoped>
#tagList {
  align-items: center;
  box-sizing: border-box;
  display: flex;
  flex-wrap: wrap;
  justify-content: flex-start;
  margin-bottom: 18px;
  min-height: 38px;
}
#tagList .tag {
  align-items: center;
  background: #eff3f6;
  border-radius: 16px;
  box-sizing: border-box;
  color: #001a34;
  display: flex;
  flex: 0 0 auto;
  font-size: 14px;
  height: 32px;
  margin: 0 6px 6px 0;
  padding: 6px 16px;
}
</style>
