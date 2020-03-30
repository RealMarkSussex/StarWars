<template>
  <div class="about">
    <h1>Profile Page</h1>
    <PeopleList></PeopleList>
  </div>
</template>

<script>
import PeopleList from "@/components/PeopleList.vue";
export default {
  components: {
    PeopleList
  }
};
</script>
