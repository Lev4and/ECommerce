<template>
  <div id="reviewsStatistic">
    <a-row :gutter="[0,24]">
      <a-col :span="24">
        <a-row
          type="flex"
          align="middle"
          justify="space-between"
        >
          <a-col>
            <a-rate
              :disabled="true"
              :allowHalf="true"
              :value="ratingValue"
            />
          </a-col>
          <a-col>
            <strong class="ant-rate-text">{{ ratingValue.toFixed(2) }} / 5</strong>
          </a-col>
        </a-row>
        <a-divider
          type="horizontal"
          style="margin-bottom: 0px;"
        />
      </a-col>
      <a-col :span="24">
        <a-row :gutter="[0,8]">
          <template v-for="score in scores">
            <a-col
              :key="score.title"
              :span="24"
            >
              <a-row :gutter="[12,0]">
                <a-col :span="6">
                  {{ score.title }}
                </a-col>
                <a-col :span="14">
                  <a-progress
                    :percent="score.value / reviewsCount * 100"
                    :show-info="false"
                  />
                </a-col>
                <a-col :span="4">
                  {{ score.value }}
                </a-col>
              </a-row>
            </a-col>
          </template>
        </a-row>
      </a-col>
      <a-col :span="24">
        <a-button
          type="primary"
          style="width: 100%; font-size: 16px; height: 40px;"
        >
          <span style="padding: 8px;">
            Написать отзыв
          </span>
        </a-button>
      </a-col>
      <a-col :span="24">
        <h3>{{ bigTitle }}</h3>
        <a-row :gutter="[0,8]">
          <template v-for="(question, i) in questions">
            <a-col
              :key="i"
              :span="24"
            >
              <a-row
                type="flex"
                justify="space-between"
              >
                <a-col>
                  {{ question.questionTitle }}{{ question.popularAnswerTitle }}
                </a-col>
                <a-col>
                  <span>
                    <a-tooltip
                      slot="suffix"
                      placement="topRight"
                    >
                      <template slot="title">
                        <a-row :gutter="[0,8]">
                          <template v-for="answer in question.answers">
                            <a-col
                              :key="answer.answerTitle"
                              :span="24"
                            >
                              <a-row :gutter="[12,0]">
                                <a-col :span="8">
                                  {{ answer.answerTitle }}
                                </a-col>
                                <a-col :span="12">
                                  <a-progress
                                    :percent="answer.percentage"
                                    :show-info="false"
                                  />
                                </a-col>
                                <a-col :span="4">
                                  {{ answer.percentage }}
                                </a-col>
                              </a-row>
                            </a-col>
                          </template>
                        </a-row>
                      </template>
                      <a-icon
                        type="info-circle"
                        style="color: rgba(0,0,0,.45)"
                      />
                    </a-tooltip>
                  </span>
                </a-col>
              </a-row>
              <a-divider
                type="horizontal"
                style="margin: 12px 0 0 0;"
              />
            </a-col>
          </template>
        </a-row>
      </a-col>
    </a-row>
  </div>
</template>

<script>
import { getWidget } from '@/services/utils/widgetsUtils'

export default {
  name: 'ReviewsStatistic',

  props: {
    product: {
      type: Object,
      default: null,
      required: false,
    },
  },

  computed: {
    widgets() {
      return this.product?.widgetStates
    },
    reviewProductScore() {
      return getWidget(this.widgets, 'webReviewProductScore')
    },
    contextQuestionsStatistic() {
      return getWidget(this.widgets, 'contextQuestionsStatistic')
    },
    reviewsCount() {
      return this.reviewProductScore?.reviewsCount || 0
    },
    ratingValue() {
      return this.reviewProductScore?.totalScore || 0
    },
    scores() {
      return this.reviewProductScore?.score || []
    },
    bigTitle() {
      return this.contextQuestionsStatistic?.bigTitle || ''
    },
    questions() {
      return this.contextQuestionsStatistic?.questions || []
    },
  },
}
</script>

<style scoped>

</style>
