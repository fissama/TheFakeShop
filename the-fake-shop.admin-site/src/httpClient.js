import Axios from 'axios'
import {BACKEND_DOMAIN_NAME} from './constants/connection';
const instance = Axios.create({
    baseURL: {BACKEND_DOMAIN_NAME},
  });
  
  export default instance;