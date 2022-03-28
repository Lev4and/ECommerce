<template>
  <div class="review-comment">
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
                <a-row :gutter=[0,6]>
                  <a-col :span="24">
                    {{ author.firstName }}
                  </a-col>
                  <a-col :span="24">
                    <a>
                      В ответ ???
                    </a>
                  </a-col>
                </a-row>
              </a-col>
            </a-row>
          </a-col>
          <a-col>
            <a-row
              type="flex"
              justify="end"
              align="middle"
            >
              <a-col>
                {{ createdAt }}
              </a-col>
            </a-row>
          </a-col>
        </a-row>
      </a-col>
      <a-col :span="24">
        <div>{{ contentComment }}</div>
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
            </a-row>
          </a-col>
          <a-col>
            <a>Ответить</a>
          </a-col>
        </a-row>
      </a-col>
    </a-row>
    <a-divider type="horizontal" />
  </div>
</template>

<script>
import moment from 'moment'

export default {
  name: 'ReviewComment',

  props: {
    comment: {
      type: Object,
      default: null,
      required: true,
    },
  },

  computed: {
    author() {
      return this.comment?.author
    },
    createdAt() {
      return moment.unix(this.comment.createdAt).utc().format('DD-MM-YYYY HH:mm:ss')
    },
    contentComment() {
      return this.comment?.comment || ''
    },
    usefulness() {
      return this.comment?.usefulness
    },
  },
}
</script>

<style scoped>

</style>
