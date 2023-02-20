import { LivrosService } from './../../service/livros-service.service';
import { ILivroModel } from './../../shared/model/livro.model';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-livros',
  templateUrl: './livros.component.html',
  styleUrls: ['./livros.component.scss']
})
export class LivrosComponent implements OnInit {

  livros: ILivroModel[] = [];

  constructor(private livrosService: LivrosService) { }

  ngOnInit(): void {
    this.listarLivros();
  }

  listarLivros () {
    this.livrosService.listarLivros().subscribe (result => {
      this.livros = result;
    }, erro => {
      console.log ('Erro ao listar os livros', erro)
    })
  }
}
