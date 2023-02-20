import { ILivroModel } from './../shared/model/livro.model';
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';



@Injectable({
  providedIn: 'root'
})
export class LivrosService {

  constructor(private http: HttpClient) {}

  urlApi = environment.apiLivraria;

  listarLivros(): Observable <ILivroModel[]> {
    return this.http.get<ILivroModel[]>(this.urlApi)
  }

}
