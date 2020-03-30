<template>
  <div>
    <b-card no-body class="overflow-hidden" style="width: 540px;">
      <b-row no-gutters>
        <b-col md="6">
          <b-card-img
            :src="imageLink"
            class="rounded-0"
            height="200px"
          ></b-card-img>
        </b-col>
        <b-col md="6">
          <b-card-body title="Horizontal Card">
            <b-card-text
              >{{ person.name }} <br />
              Their homeworld is {{ planet.name }}</b-card-text
            >
          </b-card-body>
        </b-col>
      </b-row>
    </b-card>
  </div>
</template>

<script>
import axios from "axios";
export default {
  props: {
    person: {
      type: Object,
      default: undefined
    }
  },
  data() {
    return {
      planet: undefined,
      imageLink:
        "https://vignette.wikia.nocookie.net/starwars/images/c/cc/Star-wars-logo-new-tall.jpg/revision/latest?cb=20190313021755"
    };
  },
  created() {
    axios.get(this.person.homeworld).then(res => (this.planet = res.data));
  },
  mounted() {
    if (this.person.name === "C-3PO") {
      this.imageLink =
        "https://vignette.wikia.nocookie.net/disney/images/0/0b/Starwars3-movie-screencaps.com-15461.jpg/revision/latest?cb=20160302190719";
    } else if (this.person.name === "Luke Skywalker") {
      this.imageLink =
        "https://i.guim.co.uk/img/media/14822a22caa8e704a732338e253a71cd1062cad2/0_399_2110_1265/master/2110.jpg?width=700&quality=85&auto=format&fit=max&s=f69b9498a8a2f06491135e95fbc1838e";
    } else if (this.person.name === "Darth Vader") {
      this.imageLink =
        "https://upload.wikimedia.org/wikipedia/en/thumb/7/76/Darth_Vader.jpg/220px-Darth_Vader.jpg";
    } else if (this.person.name === "R2-D2") {
      this.imageLink =
        "https://cdn.onebauer.media/one/media/5d72/5e04/ddd8/9ce2/65de/cd3a/star-wars-r2-d2-tall-image.jpg?quality=50&width=1800&ratio=16-9&resizeStyle=aspectfill&crop=2,179,763,1532&format=jpg";
    } else if (this.person.name === "Leia Organa") {
      this.imageLink =
        "https://sartorialgeek.com/wp-content/uploads/2018/09/960-e1538273942244.jpg";
    } else if (this.person.name === "Owen Lars") {
      this.imageLink = "https://i.ytimg.com/vi/5UW1PIplmlc/maxresdefault.jpg";
    } else if (this.person.name === "Beru Whitesun lars") {
      this.imageLink =
        "https://vignette.wikia.nocookie.net/starwars/images/8/87/Beru_at_the_dinner_table.png/revision/latest?cb=20170608052511";
    } else if (this.person.name === "R5-D4") {
      this.imageLink =
        "https://lumiere-a.akamaihd.net/v1/images/r5-d4_main_image_7d5f078e.jpeg?region=114%2C0%2C1332%2C666";
    } else if (this.person.name === "Biggs Darklighter") {
      this.imageLink =
        "https://upload.wikimedia.org/wikipedia/en/thumb/9/90/Biggsdarklighter.jpg/220px-Biggsdarklighter.jpg";
    } else if (this.person.name === "Obi-Wan Kenobi") {
      this.imageLink =
        "https://cnet4.cbsistatic.com/img/X0Sxfh3cMYWQn_CnugN9y4sbUZg=/1092x0/2019/08/16/65ef0311-d2a6-49f4-9b55-5fce9e60e3a1/obi2.jpg";
    }
  }
};
</script>

<style></style>
