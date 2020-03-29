<template>
  <div class="about">
    <h1>This is an about page</h1>
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
