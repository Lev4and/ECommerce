<template>
  <div class="review">
    <a-row :gutter=[0,18]>
      <a-col :span="24">
        <a-row
          type="flex"
          justify="space-between"
        >
          <a-col>
            <a-row
              type="flex"
              align="middle"
              :gutter=[12,0]
            >
              <a-col>
                <a-avatar :src="author.avatarUrl">
                  {{ author.firstName.toUpperCase()[0] }}
                </a-avatar>
              </a-col>
              <a-col>
                {{ author.fio }}
              </a-col>
            </a-row>
          </a-col>
          <a-col>
            <a-row
              type="flex"
              justify="end"
              align="middle"
              :gutter=[12,0]
            >
              <a-col>
                {{ createdAt }}
              </a-col>
              <a-col>
                <a-rate
                  :disabled="true"
                  :default-value="content.score"
                />
              </a-col>
            </a-row>
          </a-col>
        </a-row>
      </a-col>
      <a-col
        v-if="contextQuestions.length > 0"
        :span="24"
      >
        <a-row :gutter=[0,8]>
          <template v-for="contextQuestion in contextQuestions">
            <a-col
              :key="contextQuestion.question"
              :span="24"
            >
              <span>{{ contextQuestion.question }}: {{ contextQuestion.answer }}</span>
            </a-col>
          </template>
        </a-row>
      </a-col>
      <a-col
        v-if="positive"
        :span="24"
      >
        <h4>Достоинства</h4>
        <div>{{ positive }}</div>
      </a-col>
      <a-col
        v-if="negative"
        :span="24"
      >
        <h4>Недостатки</h4>
        <div>{{ negative }}</div>
      </a-col>
      <a-col
        v-if="comment"
        :span="24"
      >
        <h4>Комментарий</h4>
        <div>{{ comment }}</div>
      </a-col>
      <a-col
        v-if="content.photos.length > 0 || content.videos.length > 0"
      >
        <a-row
          :gutter=[8,16]
        >
          <template v-for="photo in content.photos">
            <a-col
              :key="photo.id"
              :sm="6" :md="4" :lg="3" :xl="2" :xxl="2"
              class="review-media"
            >
              <div class="review-media-container review-photo-container">
                <img :src="photo.url" />
              </div>
            </a-col>
          </template>
          <template v-for="video in content.videos">
            <a-col
              :key="video.id"
              :sm="12" :md="8" :lg="6" :xl="4" :xxl="4"
              class="review-media"
            >
              <div class="review-media-container review-video-container">
                <img :src="video.previewUrl" />
              </div>
            </a-col>
          </template>
        </a-row>
      </a-col>
      <a-col :span="24">
        <a-row
          type="flex"
          :gutter=[16,0]
        >
          <a-col>
            <a-row
              type="flex"
              :gutter=[16,0]
            >
              <a-col>
                <a-icon
                  type="like"
                  theme="twoTone"
                  two-tone-color="lime"
                />
                {{ usefulness.useful }}
              </a-col>
              <a-col>
                <a-icon
                  type="dislike"
                  theme="twoTone"
                  two-tone-color="red"
                />
                {{ usefulness.unuseful }}
              </a-col>
              <a-col>
                <a-icon
                  type="message"
                  theme="twoTone"
                  two-tone-color="blue"
                />
                {{ comments.totalCount }}
              </a-col>
            </a-row>
          </a-col>
          <a-col>
            <a>Ответить</a>
          </a-col>
        </a-row>
      </a-col>
      <a-col
        v-if="comments.totalCount > 0"
        :span="24"
      >
        <ReviewComments :review="review" />
      </a-col>
    </a-row>
    <a-divider type="horizontal" />
  </div>
</template>

<script>
import moment from 'moment'
import ReviewComments from '@/components/product/tabs/reviewsTab/ReviewComments'

export default {
  name: 'Review',

  components: {
    ReviewComments,
  },

  props: {
    review: {
      type: Object,
      default: null,
      required: true,
    },
  },

  computed: {
    author() {
      return this.review?.author
    },
    content() {
      return this.review?.content
    },
    comments() {
      return this.review?.comments
    },
    usefulness() {
      return this.review?.usefulness
    },
    createdAt() {
      return moment.unix(this.review.createdAt).utc().format('DD-MM-YYYY HH:mm:ss')
    },
    contextQuestions() {
      return this.content?.contextQuestions || []
    },
    positive() {
      return this.content?.positive
    },
    negative() {
      return this.content?.negative
    },
    comment() {
      return this.content?.comment
    },
  },
}
</script>

<style scoped>
.review .review-media {
  width: 210px;
  height: 270px;
}
.review-media .review-media-container {
  width: 100%;
  height: 100%;
}
.review-media-container img {
  width: 100%;
  height: 100%;
  object-fit: cover;
  border: 1px solid black;
  border-radius: 10px;
  filter: grayscale(100%);
}
.review-media-container img:hover {
  filter: grayscale(0%);
}
</style>
