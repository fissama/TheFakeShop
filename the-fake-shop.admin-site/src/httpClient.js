import Axios from 'axios'
import {BACKEND_URL} from './constants/connection';
const instance = Axios.create({
    baseURL: (BACKEND_URL),
  });
  
  export default instance;