import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ContasPagar } from '../models/contasPagar';
import { Response } from '../models/Response';

@Injectable({
  providedIn: 'root',
})
export class ContasPagarService {
  private apiurl = `${environment.ApiUrl}/ContasPagar`;

  constructor(private http: HttpClient) {}

  // GetContasPagar() : Observable<Response<ContasPagar[]>>{
  // return this.http.get<Response<ContasPagar[]>>(this.apiurl);
  GetContasPagar(): Observable<Response<ContasPagar[]>> {
    return this.http.get<Response<ContasPagar[]>>(this.apiurl);
  }
  DeleteContasPagar(
    id: number | undefined
  ): Observable<Response<ContasPagar[]>> {
    return this.http.delete<Response<ContasPagar[]>>(`${this.apiurl}?id=${id}`);
  }

  SaveContasPagar(
    contaspagar: ContasPagar
  ): Observable<Response<ContasPagar[]>> {
    return this.http.post<Response<ContasPagar[]>>(this.apiurl, contaspagar);
  }
}
