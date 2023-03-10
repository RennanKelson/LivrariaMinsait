import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { LivrosService } from 'src/app/service/livros-service.service';
import { ILivroModel } from 'src/app/shared/model/livro.model';

@Component({
  selector: 'app-editar',
  templateUrl: './editar.component.html',
  styleUrls: ['./editar.component.scss']
})
export class EditarComponent implements OnInit {

  formEdit: FormGroup;
  livro?: ILivroModel;

  constructor(
    private livrosService : LivrosService,
    private fb: FormBuilder,
    private router: Router,
    private activatedRoute: ActivatedRoute) {
      this.formEdit = this.fb.group ({
        titulo: [null, [Validators.required, Validators.minLength(1), Validators.maxLength(100)]],
        subTitulo: [null, [Validators.required, Validators.minLength(1), Validators.maxLength(100)]],
        resumo: [null, [Validators.required, Validators.minLength(1), Validators.maxLength(500)]],
        qtdePaginas: [null, [Validators.required, Validators.minLength(1), Validators.maxLength(10000)]],
        dataPublicacao: [null, [Validators.required, Validators.minLength(1), Validators.maxLength(10)]],
        editora: [null, [Validators.required, Validators.minLength(1), Validators.maxLength(150)]],
        edicao: [null, [Validators.required, Validators.minLength(1), Validators.maxLength(20)]],
        autor: [null, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
      })
   }

  ngOnInit(): void {
    const id = Number(this.activatedRoute.snapshot.paramMap.get('id'));
    console.log(id);
    this.livrosService.listarLivrosID(id).subscribe((result) => {
      this.livro = result;
      console.log(this.livro);
    });
  }

  editarLivro(){
    if (this.formEdit.valid){
      this.livrosService.editarLivros(Number(this.activatedRoute.snapshot.paramMap.get('id')),
        this.formEdit.value).subscribe(() => {
        this.router.navigate([""]);
        alert ("Edi????o feita com sucesso")
      }, erro => {
        alert ("N??o foi poss??vel editar o livro!")});
    }
  }

}
