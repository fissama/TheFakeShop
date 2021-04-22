import Axios from 'axios'

const instance = Axios.create({
    baseURL: "https://thefakestore.azurewebsites.net",
  });
  
  export default instance;