import Axios from 'axios'
import {IDENTITY_SERVER_DOMAIN_NAME} from './constants/connection'
const instance = Axios.create({
    baseURL: (IDENTITY_SERVER_DOMAIN_NAME) ,
  });
  
  export default instance;