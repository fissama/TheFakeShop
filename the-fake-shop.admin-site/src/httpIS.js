import Axios from 'axios'

const instance = Axios.create({
    baseURL: "https://thefakeidentity.azurewebsites.net",
  });
  
  export default instance;