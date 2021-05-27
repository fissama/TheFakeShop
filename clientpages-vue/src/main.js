// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue';
import App from './App';
import router from './router';
import store from './store';
import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap-vue/dist/bootstrap-vue.css';
import { BootstrapVue, BContainer, BCarousel, BCarouselSlide } from 'bootstrap-vue';

Vue.config.productionTip = false;

/* eslint-disable no-new */
Vue.use(BootstrapVue);
Vue.component('b-carousel', BCarousel);
Vue.component('b-carousel-slide', BCarouselSlide);
Vue.component('b-container', BContainer);
new Vue({
  el: '#app',
  router,
  store,
  components: { App },
  template: '<App/>',
});
