<template>
  <div class="main-image-container">
    <div class="tns-carousel-wrapper">
      <VueTinySlider
        mode="carousel"
        :items="1"
        :loop="true"
        :center="true"
        :controls-text="['❮', '❯']"
      >
        <template v-for="image in images">
          <img
            :key="image"
            :src="image"
            alt="Image"
          >
        </template>
      </VueTinySlider>
    </div>
  </div>
</template>

<script>
import VueTinySlider from 'vue-tiny-slider'
import { head as _head } from 'lodash'

export default {
  name: 'ImageContainer',

  components: {
    VueTinySlider,
  },

  props: {
    item: {
      type: Object,
      required: true,
    },
  },

  computed: {
    images() {
      return this.item?.tileImage?.images || []
    },
    mainImage() {
      return _head(this.item.tileImage.images)
    },
  },
}
</script>

<style>
.tns-carousel-wrapper {
  display: flex;
  position: relative;
}
.tns-carousel-wrapper .tns-carousel-inner {
  position: relative;
  display: flex;
  overflow: hidden;
  touch-action: manipulation;
  opacity: 0;
}
.tns-carousel-wrapper .tns-carousel-inner:active {
  cursor: -webkit-grab;
  cursor: grab;
}
.tns-carousel-wrapper .tns-carousel-inner.tns-slider {
  display: block;
  opacity: 1;
}
.tns-carousel-wrapper .tns-carousel-inner > * {
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}
.tns-carousel-wrapper .tns-carousel-inner.tns-horizontal:not(.tns-gallery) {
  display: flex;
}
.tns-carousel-wrapper .tns-carousel-inner.position-absolute {
  z-index: 0;
}

.card-img-top .tns-horizontal {
  align-items: flex-start;
}

@supports (-ms-ime-align: auto) {
  .tns-carousel-wrapper .tns-carousel-inner.tns-horizontal:not(.tns-gallery) {
    display: block;
  }
}
.tns-carousel-wrapper .tns-controls:focus {
  outline: none;
}
.tns-carousel-wrapper [data-controls] {
  position: absolute;
  top: 50%;
  width: 2.25rem;
  height: 2.25rem;
  margin-top: -1.125rem;
  transition: all 0.3s ease-in-out;
  border-radius: 50%;
  background-color: #fff;
  color: #454056;
  font-size: 0.75rem;
  line-height: 2.25rem -0.25rem;
  text-align: center;
  border: 0;
  box-shadow: 0 0.125rem 0.125rem -0.125rem rgba(31, 27, 45, 0.08), 0 0.25rem 0.75rem rgba(31, 27, 45, 0.08);
  z-index: 10;
}
.tns-carousel-wrapper [data-controls]:hover {
  color: #fd5631;
  box-shadow: 0 0.125rem 0.5rem -0.25rem rgba(31, 27, 45, 0.12), 0 0.25rem 1rem rgba(31, 27, 45, 0.12);
}
.tns-carousel-wrapper [data-controls][disabled] {
  opacity: 0 !important;
  visibility: hidden;
}
.tns-carousel-wrapper.tns-carousel-light [data-controls] {
  background-color: rgba(255, 255, 255, 0.04);
  color: #fff;
  box-shadow: none;
}
.tns-carousel-wrapper.tns-carousel-light [data-controls]:hover {
  background-color: #fff;
  color: #fd5631;
}
.tns-carousel-wrapper [data-controls=prev] {
  left: 1rem;
}
.tns-carousel-wrapper [data-controls=prev] > i:not(.fi-chevron-up) {
  margin-right: 0.0625rem;
}
.tns-carousel-wrapper [data-controls=prev] > i.fi-chevron-up {
  margin-bottom: 0.125rem;
}
.tns-carousel-wrapper [data-controls=next] {
  right: 1rem;
}
.tns-carousel-wrapper [data-controls=next] > i:not(.fi-chevron-down) {
  margin-left: 0.0625rem;
}
.tns-carousel-wrapper:not(.tns-controls-static):not([class^=tns-controls-outside]):not([class*=" tns-controls-outside"]) [data-controls] {
  opacity: 0;
}
.tns-carousel-wrapper:not(.tns-controls-static):not([class^=tns-controls-outside]):not([class*=" tns-controls-outside"]) [data-controls=prev] {
  transform: translateX(1rem);
}
.tns-carousel-wrapper:not(.tns-controls-static):not([class^=tns-controls-outside]):not([class*=" tns-controls-outside"]) [data-controls=next] {
  transform: translateX(-1rem);
}
.tns-carousel-wrapper:not(.tns-controls-static):not([class^=tns-controls-outside]):not([class*=" tns-controls-outside"]):hover [data-controls] {
  transform: none;
  opacity: 1;
}
.tns-carousel-wrapper.tns-nav-outside [data-controls] {
  margin-top: -2.9rem;
}

.tns-carousel-controls {
  display: flex;
}
.tns-carousel-controls button {
  display: none;
}
.tns-carousel-controls:focus {
  outline: none;
}
.tns-carousel-controls [data-controls] {
  display: block;
  width: 2.25rem;
  height: 2.25rem;
  transition: all 0.3s ease-in-out;
  border-radius: 50%;
  background-color: #fff;
  color: #454056;
  font-size: 0.75rem;
  line-height: 2.25rem -0.25rem;
  text-align: center;
  z-index: 10;
  border: 0;
  box-shadow: 0 0.125rem 0.125rem -0.125rem rgba(31, 27, 45, 0.08), 0 0.25rem 0.75rem rgba(31, 27, 45, 0.08);
}
.tns-carousel-controls [data-controls]:hover {
  color: #fd5631;
  box-shadow: 0 0.125rem 0.5rem -0.25rem rgba(31, 27, 45, 0.12), 0 0.25rem 1rem rgba(31, 27, 45, 0.12);
}
.tns-carousel-controls [data-controls][disabled] {
  opacity: 0 !important;
  visibility: hidden;
}
.tns-carousel-controls [data-controls=prev] > i:not(.fi-chevron-up) {
  margin-right: 0.0625rem;
}
.tns-carousel-controls [data-controls=prev] > i.fi-chevron-up {
  margin-bottom: 0.125rem;
}
.tns-carousel-controls [data-controls=next] > i:not(.fi-chevron-down) {
  margin-left: 0.0625rem;
}
.tns-carousel-controls.tns-carousel-light [data-controls] {
  background-color: rgba(255, 255, 255, 0.04);
  color: #fff;
  box-shadow: none;
}
.tns-carousel-controls.tns-carousel-light [data-controls]:hover {
  background-color: #fff;
  color: #fd5631;
}

.tns-carousel-wrapper:not(.tns-nav-outside) .tns-nav {
  position: absolute;
  left: 0;
  width: 100%;
  bottom: -25px;
  z-index: 100;
  display: flex;
  text-align: center;
  align-items: center;
  justify-content: space-around;
}
.tns-carousel-wrapper [data-nav] {
  display: inline-block;
  width: 1rem;
  height: 1rem;
  margin: 0 0.3rem;
  padding: 0;
  transition: width 0.2s ease-in-out, background-color 0.2s ease-in-out;
  border: 0;
  border-radius: 50%;
  z-index: 100;
  background-color: blue;
}
.tns-carousel-wrapper [data-nav]:focus {
  outline: none;
}
.tns-carousel-wrapper [data-nav].tns-nav-active {
  background-color: red;
}
.tns-carousel-wrapper.tns-nav-outside .tns-nav {
  padding-top: 1.25rem;
  padding-bottom: 1rem;
  text-align: center;
}
.tns-carousel-wrapper.tns-nav-outside:not(.tns-carousel-light) [data-nav] {
  background-color: rgba(102, 98, 118, 0.4);
}
.tns-carousel-wrapper.tns-nav-outside:not(.tns-carousel-light) [data-nav].tns-nav-active {
  background-color: #666276;
}
.tns-carousel-wrapper.tns-nav-outside-flush .tns-nav {
  padding: 0;
}

.tns-controls-outside-sm .tns-controls {
  display: none;
}
@media (min-width: 500px) {
  .tns-controls-outside-sm .tns-controls {
    display: block;
  }
  .tns-controls-outside-sm [data-controls=prev] {
    left: -3rem;
  }
  .tns-controls-outside-sm [data-controls=next] {
    right: -3rem;
  }
}
.tns-controls-outside-md .tns-controls {
  display: none;
}
@media (min-width: 768px) {
  .tns-controls-outside-md .tns-controls {
    display: block;
  }
  .tns-controls-outside-md [data-controls=prev] {
    left: -3rem;
  }
  .tns-controls-outside-md [data-controls=next] {
    right: -3rem;
  }
}
.tns-controls-outside-lg .tns-controls {
  display: none;
}
@media (min-width: 992px) {
  .tns-controls-outside-lg .tns-controls {
    display: block;
  }
  .tns-controls-outside-lg [data-controls=prev] {
    left: -3rem;
  }
  .tns-controls-outside-lg [data-controls=next] {
    right: -3rem;
  }
}
.tns-controls-outside-xl .tns-controls {
  display: none;
}
@media (min-width: 1200px) {
  .tns-controls-outside-xl .tns-controls {
    display: block;
  }
  .tns-controls-outside-xl [data-controls=prev] {
    left: -3rem;
  }
  .tns-controls-outside-xl [data-controls=next] {
    right: -3rem;
  }
}
.tns-controls-outside-xxl .tns-controls {
  display: none;
}
@media (min-width: 1400px) {
  .tns-controls-outside-xxl .tns-controls {
    display: block;
  }
  .tns-controls-outside-xxl [data-controls=prev] {
    left: -3rem;
  }
  .tns-controls-outside-xxl [data-controls=next] {
    right: -3rem;
  }
}
.tns-controls-outside .tns-controls {
  display: none;
}
.tns-controls-outside .tns-controls {
  display: block;
}
.tns-controls-outside [data-controls=prev] {
  left: -3rem;
}
.tns-controls-outside [data-controls=next] {
  right: -3rem;
}

.tns-slides-count {
  position: absolute;
  display: flex;
  align-items: center;
  right: 1.5rem;
  bottom: 1.25rem;
  z-index: 10;
}

.tns-thumbnails {
  display: flex;
  flex-wrap: wrap;
  margin-right: -0.4375rem;
  margin-left: -0.4375rem;
  padding: 0.4375rem 0;
  list-style: none;
}
.tns-thumbnails:focus {
  outline: none;
}

.tns-thumbnail {
  display: block;
  width: 20%;
  margin: 0;
  padding: 0.4375rem;
  cursor: pointer;
}
.tns-thumbnail:focus {
  outline: none;
}
.tns-thumbnail > img {
  display: block;
  width: 100%;
  transition: opacity 0.2s ease-in-out, border-color 0.2s ease-in-out;
  border: 1px solid transparent;
  border-radius: 0.5rem;
  opacity: 0.6;
}
.tns-thumbnail:hover > img {
  opacity: 1;
}
.tns-thumbnail.tns-nav-active {
  pointer-events: none;
  cursor: default;
}
.tns-thumbnail.tns-nav-active > img {
  border-color: #fd5631;
  opacity: 1;
}

@media (max-width: 499.98px) {
  .tns-thumbnails {
    margin-right: -0.291375rem;
    margin-left: -0.291375rem;
    padding: 0.291375rem 0;
  }

  .tns-thumbnail {
    width: 33.33%;
    padding: 0.291375rem;
  }
}
.card > .card-img-hover .tns-nav {
  display: none;
}
.card > .card-img-hover [data-controls] {
  transform: none !important;
  background: none;
  color: #fff;
  font-size: 1.03125rem;
  box-shadow: none;
}
.card > .card-img-hover [data-controls=prev] {
  left: 0.25rem;
}
.card > .card-img-hover [data-controls=next] {
  right: 0.25rem;
}
.card:hover > .card-img-hover [data-controls] {
  opacity: 1 !important;
}
.tns-inner {
  overflow: hidden;
}
.tns-center .tns-inner {
  margin-right: -1rem !important;
}
@media (min-width: 768px) {
  .tns-center .tns-inner {
    margin: 0 15% 0 16.5% !important;
  }
  .tns-center .tns-item {
    transition: opacity 0.15s ease-in-out;
    opacity: 0.6;
  }
  .tns-center .tns-item.tns-slide-active.active:not(.tns-slide-cloned) {
    opacity: 1;
  }
}

.tns-item {
  -webkit-user-select: none;
  -moz-user-select: none;
  user-select: none;
}
.tns-item .from-top, .tns-item .from-bottom,
.tns-item .from-start, .tns-item .from-end,
.tns-item .scale-up, .tns-item .scale-down {
  transition: all 0.45s 0.3s ease-in-out;
  opacity: 0;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}
.tns-item .from-top {
  transform: translateY(-45px);
}
.tns-item .from-bottom {
  transform: translateY(45px);
}
.tns-item .from-start {
  transform: translateX(-45px);
}
.tns-item .from-end {
  transform: translateX(45px);
}
.tns-item .scale-up {
  transform: scale(0.8);
}
.tns-item .scale-down {
  transform: scale(1.2);
}
.tns-item .delay-1 {
  transition-delay: 0.5s;
}
.tns-item .delay-2 {
  transition-delay: 0.7s;
}
.tns-item .delay-3 {
  transition-delay: 0.9s;
}
.tns-item .delay-4 {
  transition-delay: 1.1s;
}
.tns-item.tns-slide-active .from-top, .tns-item.tns-slide-active .from-bottom {
  transform: translateY(0);
  opacity: 1;
}
.tns-item.tns-slide-active .from-start, .tns-item.tns-slide-active .from-end {
  transform: translateX(0);
  opacity: 1;
}
.tns-item.tns-slide-active .scale-up, .tns-item.tns-slide-active .scale-down {
  transform: scale(1);
  opacity: 1;
}
.tns-outer {
  display: flex;
}
.tns-ovh {
  display: flex;
  align-items: center;
}
.tns-liveregion.tns-visually-hidden {
  display: none;
}
img.tns-item {
  max-height: 180px;
  object-fit: contain;
}
</style>

<style scoped>
.main-image-container {
  max-width: 200px;
  min-width: 200px;
  min-height: 200px;
  max-height: 200px;
  padding: 12px;
  display: flex;
  align-self: center;
}
</style>
