import { Component, OnInit } from '@angular/core';
import { LivrosService } from 'src/app/service/livros-service.service';
import { ILivroModel } from 'src/app/shared/model/livro.model';


@Component({
  selector: 'app-buscar',
  templateUrl: './buscar.component.html',
  styleUrls: ['./buscar.component.css']
})
export class BuscarComponent implements OnInit {

  livroID!: ILivroModel;

  constructor(private livrosService: LivrosService) { }

  ngOnInit() {
  }

  listarLivrosId (id : number) {
    this.livrosService.listarLivrosID(id).subscribe (result => {
    this.livroID = result
    }, erro => {
      console.log ('Erro ao listar livro por ID', erro)
    })
  }

}
