import http from '../httpIS';

class UserService {
  pathSer = "user";

  getList() {
    return http.get(this.pathSer);
  }
}

export default new UserService();
