import httpClient from'../Helpers/httpHelper'
import axios, { AxiosInstance, AxiosRequestConfig } from "axios";
import { UrlBackEnd } from "../Constants/oidc_config";
import qs from 'qs';

import RequestService from './Request';
import EndPoints from '../Constants/endpoints';

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
  //   return RequestService.axios.get(EndPoints.realestate, {
  //     params: query,
  //     paramsSerializer: params => qs.stringify(params),
  // });
    return this.axios.get(this.pathSer);
  }

  get(id){
    return this.axios.get(this.pathSer+"/"+id);
  }
  edit(id, objectEdit) {
    return this.axios.put(this.pathSer + "/" + id, objectEdit);
  }

  delete(id) {
    return this.axios.delete(this.pathSer + "/" + id);  
  }

  create(objectNew) {
    // const formData = new FormData();

    // Object.keys(objectNew).forEach(key => {
    //     formData.append(key, objectNew[key]);
    // });

    // return RequestService.axios.post(EndPoints.realestate, formData);
    return httpClient.post(this.pathSer, objectNew);
  }
}
  export default new BatDongSanService();