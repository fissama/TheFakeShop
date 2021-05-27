<template>
  <listOfProducts :products="getSkinCare"/>
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
      'getSkinCare',
    ]),
  },
};
</script>

<style>
</style>

