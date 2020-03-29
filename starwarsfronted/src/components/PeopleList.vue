<template>
  <div>
    <div v-for="person in people.results" :key="person.created" class="inline">
      <People :person="person"></People>
    </div>
  </div>
</template>

<script>
import axios from "axios";
import People from "./People";
export default {
  data() {
    return {
      people: [],
      searchTerm: ""
    };
  },
  components: {
    People
  },
  created() {
    axios
      .get("https://swapi.co/api/people/")
      .then(res => (this.people = res.data));
  }
};
</script>

<style>
.inline {
  display: inline-block;
}
</style>
