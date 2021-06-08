<template>
  <div class="listOfProducts">
    <!-- <carousel> </carousel> -->
    <ul style="display:flex; flex-wrap:wrap;">
      <li v-for="(product, index) in products" :key="index" class="product">
        <img v-bind:src="product.image" alt="this is image" />
        <router-link to="/product-details">
          <h2 class="product-name" @click="addCurrentProduct(product)">
            {{ product.name }}
          </h2>
        </router-link>
        <div class="product-price">
          <span> {{ product.price }} VND</span>
        </div>

        <btn
          btnColor="btn btn-large btn-sucess"
          :cartIcon="true"
          @click.native="addProductToCart(product)"
        >
          Add cart
        </btn>
      </li>
    </ul>
  </div>
</template>

<script>
import { mapActions } from 'vuex';
import btn from './Btn';
import carousel from './Carousel';

export default {
  props: ['products'],

  components: {
    btn,
    carousel,
  },
  methods: {
    ...mapActions([
      'addProduct',
      'currentProduct',
    ]),

    addProductToCart(product) {
      this.addProduct(product);
    },
    addCurrentProduct(product) {
      this.currentProduct(product);
    },
  },
};
</script>

<style scoped>
.listOfProducts {
  width: 100%;
  max-width: 1000px;
  margin: 0 auto;
  display: contents;
  flex-wrap: wrap;
  justify-content: space-around;
  padding: 0;
}

.listOfProducts li img {
  width: 250px;
  height: 250px;
}

.product {
  width: 300px;
  background-color: #fff;
  list-style: none;
  box-sizing: border-box;
  padding: 1em;
  margin: 1em 0;
  display: flex;
  flex-direction: column;
  align-items: center;
  border-radius: 7px;
}

.product-name {
  font-size: 1.2em;
  font-weight: normal;
  height: 100px;
}

.product-name:hover {
  cursor: pointer;
  text-decoration: underline;
}

.product-price {
  width: 100%;
  align-self: flex-start;
  display: flex;
  justify-content: space-between;
  margin-bottom: 0.5em;
}
</style>

