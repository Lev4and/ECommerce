<template>
  <a-row
    type="flex"
    justify="space-between"
    align="middle"
    :gutter="8"
  >
    <a-col :span="6">
      <a-badge :count="1">
        <a-icon type="user" />
      </a-badge>
    </a-col>
    <a-col :span="6">
      <a-badge :count="1">
        <a-icon type="shopping-cart" />
      </a-badge>
    </a-col>
    <a-col :span="6">
      <a-badge :count="1">
        <a-icon type="heart" />
      </a-badge>
    </a-col>
    <a-col :span="6">
      <a-badge :count="1">
        <a-icon type="shopping" />
      </a-badge>
    </a-col>
  </a-row>
</template>

<script>
export default {
  name: 'LayoutHeaderActions',
}
</script>

<style scoped>
i.anticon {
  font-size: 24px;
}
</style>
