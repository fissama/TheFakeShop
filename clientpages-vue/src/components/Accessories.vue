<template>
  <listOfProducts :products="getAccessories"/>
</template>

<script>

import { mapGetters } from 'vuex';
import listOfProducts from './ListOfProducts';

export default {
  components: {
    listOfProducts,
  },

  computed: {
    ...mapGetters([
      'getAccessories',
    ]),
  },
};

</script>

<style>

</style>
