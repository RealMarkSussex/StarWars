<template>
  <h1>{{ starship.name }}</h1>
</template>

<script>
export default {
  props: {
    starship: {
      type: Object,
      default: undefined
    }
  }
};
</script>

<style></style>
