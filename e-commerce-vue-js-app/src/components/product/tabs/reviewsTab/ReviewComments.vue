<template>
  <div class="review-comments">
    <a-spin
      :spinning="!isLoading"
    >
      <a-icon
        slot="indicator"
        type="loading"
        style="font-size: 96px"
        spin
      />
      <a-row :gutter="[0,24]">
        <a-col :span="24">
          <h4>Комментарии</h4>
        </a-col>
        <template v-for="comment in comments">
          <a-col
            :key="comment.id"
            :span="24"
          >
            <ReviewComment :comment="comment" />
          </a-col>
        </template>
        <a-col :span="24">
          <a
            v-if="page < totalPages"
            @click="onClickShowMoreComments"
          >
            Показать больше ответов
          </a>
        </a-col>
      </a-row>
    </a-spin>
  </div>
</template>

<script>
import { ceil as _ceil } from 'lodash'
import API from '@/api'
import ReviewComment from '@/components/product/tabs/reviewsTab/reviewComments/ReviewComment'

export default {
  name: 'ReviewComments',

  components: {
    ReviewComment,
  },

  props: {
    review: {
      type: Object,
      default: null,
      required: true,
    },
  },

  data: () => ({
    page: 0,
    comments: [],
    isLoading: true,
  }),

  computed: {
    totalCount() {
      return this.review?.comments?.totalCount || 0
    },
    totalPages() {
      return _ceil(this.totalCount / 10)
    },
  },

  methods: {
    async loadComments() {
      this.isLoading = false
      this.comments.push(...(await API.product.getCommentsByReview(this.review.id, 10, 10 * (this.page - 1)))?.comments || [])
      this.isLoading = true
    },
    async onClickShowMoreComments() {
      this.page += 1
      await this.loadComments()
    },
  },
}
</script>

<style>
.review-comments .ant-spin.ant-spin-spinning {
  top: 50% !important;
  left: 50% !important;
  z-index: 4 !important;
  width: auto !important;
  height: auto !important;
  position: fixed !important;
  margin-top: -48px !important;
  margin-left: -48px !important;
}
</style>

<style scoped>

</style>
