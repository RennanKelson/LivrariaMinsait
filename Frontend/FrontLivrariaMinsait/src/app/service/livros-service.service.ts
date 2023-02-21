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

  listarLivrosID (id: number) : Observable <ILivroModel> {
    return this.http.get<ILivroModel>(`${this.urlApi}/${id}`);
  }

  removerLivros(id: number){
    return this.http.delete(`${this.urlApi}/${id}`).subscribe((result)=> {
      console.log(result)
    });
  }
  
  cadastroLivros(livro : ILivroModel) {
    return this.http.post(this.urlApi, livro)
  }

  editarLivros(id : number, livro: ILivroModel) {
    return this.http.put(`${this.urlApi}/${id}`, livro)
  }
}
