<template>
  <div>
    <h1>{{ person.name }}</h1>
    <b-button @click="$emit('close')"
      ><b-icon icon="x-square"></b-icon
    ></b-button>
  </div>
</template>

<script>
export default {
  props: {
    person: {
      type: Object,
      default: undefined
    }
  }
};
</script>

<style></style>
