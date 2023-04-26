import { ILivroModelCadastro } from './../../../shared/model/livro-cadastro.model';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormArray } from '@angular/forms';
import { LivrosService } from 'src/app/service/livros-service.service';
import { Router } from '@angular/router';
import { ILivroModel } from 'src/app/shared/model/livro.model';


@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.scss']
})
export class CadastroComponent implements OnInit {

  formCadastro: FormGroup;


  constructor(
    private cadastroService : LivrosService,
    private fb: FormBuilder,
    private router: Router) {
      this.formCadastro = this.fb.group ({
        titulo: [null, [Validators.minLength(1), Validators.maxLength(100)]],
        subTitulo: [null, [Validators.minLength(1), Validators.maxLength(100)]],
        resumo: [null, [Validators.minLength(1), Validators.maxLength(500)]],
        qtdePaginas: [null, [Validators.required, Validators.minLength(1), Validators.maxLength(10000)]],
        dataPublicacao: [null, [Validators.required, Validators.minLength(1), Validators.maxLength(10)]],
        editora: [null, [Validators.required, Validators.minLength(1), Validators.maxLength(150)]],
        edicao: [null, [Validators.minLength(1), Validators.maxLength(20)]],
        autor: [null, this.fb.array([this.criarAutor()])]
      })
   }

  ngOnInit(): void {
  }

  criarAutor(): FormGroup {
    return this.fb.group({
      nome: [null, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
    });
  }

  adicionarAutor(): void {
    const control = this.formCadastro.controls['autor'] as FormArray;
    control.push(this.criarAutor());
  }

  novoCadastro () {
    const livro: ILivroModelCadastro = this.formCadastro.value;
    console.log(livro);
    this.cadastroService.cadastroLivros (livro).subscribe(()=> {this.router.navigate([""]);
    alert("Cadastro realizado com sucesso")},
    erro => {
      alert ("não foi possível realizar o cadastro");
      console.log(erro);
    });
  }
}
