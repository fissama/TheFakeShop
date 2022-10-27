<template>
  <listOfProducts :products="getCleansers"/>
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
      'getCleansers',
    ]),
  },
};
</script>

<style>
</style>

