<template>
  <div>
    <div v-if="loading">
      <b-icon icon="arrow-clockwise" animation="spin" font-scale="4"></b-icon>
    </div>
    <div class="container" v-else>
      <h1>Profiles</h1>
      <form @submit="filterPeople(searchTerm)">
        <div>
          <b-input-group size="sm" class="mb-2">
            <b-input-group-prepend is-text>
              <b-icon icon="search"></b-icon>
            </b-input-group-prepend>
            <b-form-input
              type="search"
              placeholder="Search terms"
              v-model="searchTerm"
            ></b-form-input>
          </b-input-group>
        </div>
      </form>
    </div>
    <br />
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
      searchTerm: "",
      loading: true
    };
  },
  components: {
    People
  },
  mounted() {
    axios.get("https://swapi.co/api/people/").then(res => {
      this.people = res.data;
      this.loading = false;
    });
  },
  methods: {
    filterPeople(searchTerm) {
      axios
        .get("https://swapi.co/api/people/?search=" + searchTerm)
        .then(res => (this.people = res.data));
    }
  }
};
</script>

<style>
.inline {
  display: inline-block;
}
</style>
