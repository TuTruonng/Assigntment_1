import httpClient from'../Helpers/httpHelper'
import axios, { AxiosInstance, AxiosRequestConfig } from "axios";
import { UrlBackEnd } from "../Constants/oidc_config";

const config = {
  baseURL: UrlBackEnd
}


class BatDongSanService {
  axios;
  pathSer = "RealEstate";

  constructor() {
    this.axios = axios.create(config);
  }
    
  getList() {
    return this.axios.get(this.pathSer);
  }

  get(id){
    return httpClient.get(this.pathSer+"/"+id);
  }
  edit(id, objectEdit) {
    return httpClient.put(this.pathSer + "/" + id, objectEdit);
  }

  delete(id) {
    return httpClient.delete(this.pathSer + "/" + id);  
  }

  create(objectNew) {
    return httpClient.post(this.pathSer, objectNew);
  }
}
  export default new BatDongSanService();