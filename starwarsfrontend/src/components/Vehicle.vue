<template>
  <h1>{{ vehicle.name }}</h1>
</template>

<script>
export default {
  props: {
    vehicle: {
      type: Object,
      default: undefined
    }
  }
};
</script>

<style></style>
