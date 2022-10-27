<template>
  <listOfProducts :products="getBodyCare"/>
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
      'getBodyCare',
    ]),
  },
};
</script>

<style>
</style>

