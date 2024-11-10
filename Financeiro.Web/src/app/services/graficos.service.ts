import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment.development';
import { ContasPagar } from '../models/contasPagar';
import { Observable } from 'rxjs';
import { Response } from '../models/Response';


@Injectable({
  providedIn: 'root'
})
export class GraficosService {
  private  apiurl = `${environment.ApiUrl}/ContasPagar`
  constructor(private http: HttpClient) { }

  GetContasPagarGraficos() : Observable<Response<ContasPagar[]>>{
    return this.http.get<Response<ContasPagar[]>>(this.apiurl);
  }
  
  getChartInfo() {
    return this.http.get(this.apiurl);
  }
}