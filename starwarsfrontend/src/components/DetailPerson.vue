<template>
  <div class="auto-size">
    <h1>{{ person.name }}</h1>
    <Starship
      v-for="starship in person.starships"
      :key="starship.name"
      :starship="starship"
    ></Starship>
    <Species :species="person.species"></Species>
    <Vehicle
      v-for="vehicle in person.vehicles"
      :key="vehicle.name"
      :vehicle="vehicle"
    ></Vehicle>
    <b-button @click="$emit('close')"
      ><b-icon icon="x-square"></b-icon
    ></b-button>
  </div>
</template>

<script>
import Vehicle from "./Vehicle";
import Starship from "./Starship";
import Species from "./Species";
export default {
  props: {
    person: {
      type: Object,
      default: undefined
    }
  },
  components: {
    Vehicle,
    Starship,
    Species
  }
};
</script>

<style>
.auto-size {
  width: auto;
  height: auto;
}
</style>
