<template>
  <div>
    <div class="container">
      <h1>Profiles</h1>
      <form @submit="filterPeople(searchTerm)">
        <div class="input-group input-group-lg">
          <input
            type="text"
            class="form-control"
            placeholder="Search"
            v-model="searchTerm"
          />
          <div class="input-group-btn">
            <button class="btn btn-default" type="submit">
              <b-icon-search></b-icon-search>
            </button>
          </div>
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
