import Vue from "vue";
import App from "./App.vue";
import router from "./router";
import "bootstrap/dist/css/bootstrap.css";
import "bootstrap-vue/dist/bootstrap-vue.css";
import axios from "axios";
import { BootstrapVue, IconsPlugin } from "bootstrap-vue";
import VModal from "vue-js-modal";

Vue.use(VModal, { dynamic: true });
// Install BootstrapVue
Vue.use(BootstrapVue);
// Optionally install the BootstrapVue icon components plugin
Vue.use(IconsPlugin);

Vue.config.productionTip = false;
Vue.use(axios);
new Vue({
  router,
  render: h => h(App)
}).$mount("#app");
