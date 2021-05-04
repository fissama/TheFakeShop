import Axios from 'axios'
import {IDENTITY_SERVER_URL} from './constants/connection'
const instance = Axios.create({
    baseURL: (IDENTITY_SERVER_URL) ,
  });
  
  export default instance;