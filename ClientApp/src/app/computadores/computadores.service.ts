import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Computador } from '../models/Computador';

import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ComputadoresService {

  baseURL = `${environment.UrlPrincipal}computadores`;

  constructor(private http: HttpClient) { }

  getAll(): Observable<Computador[]> {
    return this.http.get<Computador[]>(this.baseURL);
  }

  getById(id: number): Observable<Computador> {
    return this.http.get<Computador>(`${this.baseURL}/${id}`);
  }

  getByDisciplinaId(id: number): Observable<Computador[]> {
    return this.http.get<Computador[]>(`${this.baseURL}/ByDisciplina/${id}`);
  }

  post(computador: Computador) {
    return this.http.post(this.baseURL, computador);
  }

  put(computador: Computador) {
    return this.http.put(`${this.baseURL}/${computador.id}`, computador);
  }

  delete(id: number) {
    return this.http.delete(`${this.baseURL}/${id}`);
  }

}

