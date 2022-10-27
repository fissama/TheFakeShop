import Vue from 'vue';
import Router from 'vue-router';
import AllProducts from '../components/AllProducts';
import Cleansers from '../components/Cleansers';
import SkinCare from '../components/SkinCare';

import BodyCare from '../components/BodyCare';
import Accessories from '../components/Accessories';
import Product from '../components/Product';
import CartCheckout from '../components/CartCheckout';

Vue.use(Router);

export default new Router({
  routes: [
    {
      path: '',
      name: 'All Products',
      component: AllProducts,
    },
    {
      path: '/Cleansers',
      name: 'Cleansers',
      component: Cleansers,
    },
    {
      path: '/SkinCare',
      name: 'SkinCare',
      component: SkinCare,
    },
    {
      path: '/BodyCare',
      name: 'BodyCare',
      component: BodyCare,
    },
    {
      path: '/Accessories',
      name: 'Accessories',
      component: Accessories,
    },
    {
      path: '/product-details',
      name: 'Product',
      component: Product,
    },
    {
      path: '/checkout',
      name: 'Checkout',
      component: CartCheckout,
    },
  ],
});
