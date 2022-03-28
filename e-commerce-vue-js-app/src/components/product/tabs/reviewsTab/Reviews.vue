<template>
  <div id="reviews">
    <a-spin
      :spinning="!isLoading"
    >
      <a-icon
        slot="indicator"
        type="loading"
        style="font-size: 96px"
        spin
      />
      <a-row :gutter="[0,48]">
        <a-col :span="24">
          <h3>Фото и видео покупателей</h3>
          <a-row
            :gutter=[8,16]
            class="reviews-media-content"
          >
            <template v-for="(content, i) in mediaContent">
              <a-col
                :key="i"
                :sm="6" :md="4" :lg="3" :xl="2" :xxl="2"
                class="reviews-media-content-item"
              >
                <div class="reviews-media-content-item-container">
                  <img :src="content.previewUrl" />
                </div>
              </a-col>
            </template>
            <a-col
              v-if="moreMedia"
              :sm="6" :md="4" :lg="3" :xl="2" :xxl="2"
              class="reviews-media-content-item"
            >
              <div class="reviews-media-content-item-container">
                <strong style="display: flex; height: 100%; justify-content: center; align-items: center;">+ {{ moreMedia.mediaCount }}</strong>
              </div>
            </a-col>
          </a-row>
          <a-divider type="horizontal" />
        </a-col>
        <a-col
          :span="24"
          class="reviews-container"
        >
          <template v-for="review in reviews">
            <Review
              :key="review.id"
              :review="review"
            />
          </template>
        </a-col>
        <a-col :span="24">
          <a-pagination
            class="pagination"
            :total="totalPages"
            :pageSize="perPage"
            :current="currentPage"
            @change="onCurrentPageChanged"
          />
        </a-col>
      </a-row>
    </a-spin>
  </div>
</template>

<script>
import API from '@/api'
import { getWidget } from '@/services/utils/widgetsUtils'
import Review from '@/components/product/tabs/reviewsTab/Review'

export default {
  name: 'Reviews',

  components: {
    Review,
  },

  props: {
    product: {
      type: Object,
      default: null,
      required: false,
    },
    asyncData: {
      default: '',
      type: String,
      required: false,
    },
    productUrl: {
      default: '',
      type: String,
      required: false,
    },
  },

  data: () => ({
    isLoading: true,
    reviewsListing: null,
  }),

  watch: {
    productUrl: {
      handler() {
        this.loadReviews(1)
      },
      deep: true,
      immediate: true,
    },
  },

  computed: {
    widgets() {
      return this.product?.widgetStates
    },
    listPhotos() {
      return getWidget(this.widgets, 'webListPhotos')
    },
    mediaContent() {
      return this.listPhotos?.mediaContent || []
    },
    moreMedia() {
      return this.listPhotos?.moreMedia
    },
    url() {
      return this.$route.query.url
    },
    state() {
      return this.reviewsListing?.state
    },
    reviews() {
      return this.state?.reviews
    },
    paging() {
      return this.state?.paging
    },
    perPage() {
      return this.paging?.perPage || 1
    },
    totalPages() {
      return this.paging?.total * this.perPage || 1
    },
    currentPage() {
      return this.paging?.rgPage || 1
    },
  },

  methods: {
    async loadReviews(page) {
      if (this.productUrl && this.asyncData) {
        this.isLoading = false
        this.reviewsListing = await API.product.getReviewsListing(this.productUrl, this.asyncData, page)
        this.isLoading = true
      }
    },
    async onCurrentPageChanged(page) {
      await this.loadReviews(page)
    },
  },
}
</script>

<style>
#reviews .ant-spin.ant-spin-spinning {
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
#reviews .reviews-media-content .reviews-media-content-item {
  width: 100px;
  height: 100px;
}
.reviews-media-content-item .reviews-media-content-item-container {
  width: 100%;
  height: 100%;
}
.reviews-media-content-item-container img {
  width: 100%;
  height: 100%;
  object-fit: cover;
  border: 1px solid black;
  border-radius: 10px;
  filter: grayscale(100%);
}
.reviews-media-content-item-container img:hover {
  filter: grayscale(0%);
}
ul.pagination {
  display: flex;
  flex-direction: row;
  justify-content: center;
}
</style>
