<template>
  <h1>{{ species.classification }}</h1>
</template>

<script>
export default {
  props: {
    species: {
      type: Object,
      default: undefined
    }
  }
};
</script>

<style></style>
