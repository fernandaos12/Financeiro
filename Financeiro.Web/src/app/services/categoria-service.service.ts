import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { Observable } from 'rxjs';
import { Categoria } from '../models/categoria';
import { Response } from '../models/Response';
@Injectable({
  providedIn: 'root',
})
export class CategoriaServiceService {
  constructor(private http: HttpClient) {}

  private apiurl = `${environment.ApiUrl}/Categorias`;

  GetSelectCategorias(): Observable<Response<Categoria[]>> {
    return this.http.get<Response<Categoria[]>>(this.apiurl);
  }
}
