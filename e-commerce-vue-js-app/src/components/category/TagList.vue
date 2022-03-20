<template>
  <div
    v-if="tags.length > 0"
    id="tagList"
  >
    <template v-for="tag in tags">
      <a-tag
        :key="tag.link"
        :class="'tag'"
        :visible="true"
        :closable="tag.link === url"
        :color="tag.link === url ? 'red' : ''"
        @close="onCloseTag"
      >
        <router-link :to="{ name: 'Category', query: { url: tag.link, p: 1 } }">
          {{ tag.name }}
        </router-link>
      </a-tag>
    </template>
  </div>
</template>

<script>
import { mapGetters } from 'vuex'

export default {
  name: 'TagList',

  computed: {
    ...mapGetters({
      tagList: 'category/tagList',
      tags: 'category/tags',
    }),
    url() {
      return this.$route.query.url
    },
  },

  methods: {
    onCloseTag() {
      this.$router.push({ name: 'Category', query: { url: this.tagList?.baseUrl, p: 1 } })
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
