<template>
  <div id="backToTop">
    <a-back-top>
      <div class="ant-back-top-inner">
        <a-icon type="arrow-up" />
      </div>
    </a-back-top>
  </div>
</template>

<script>
export default {
  name: 'BackToTop',
}
</script>

<style scoped>
#backToTop .ant-back-top {
  bottom: 100px;
}
#backToTop .ant-back-top-inner {
  height: 40px;
  width: 40px;
  line-height: 40px;
  border-radius: 50%;
  background-color: #1088e9;
  color: #fff;
  text-align: center;
  font-size: 20px;
}
</style>
