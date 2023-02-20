import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
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
        titulo: [null, [Validators.required, Validators.minLength(3), Validators.maxLength(100)]],
        subTitulo: [null, [Validators.required, Validators.minLength(3), Validators.maxLength(100)]],
        resumo: [null, [Validators.required, Validators.minLength(3), Validators.maxLength(100)]],
        qtdePaginas: [null, [Validators.required, Validators.minLength(3), Validators.maxLength(100)]],
        dataPublicacao: [null, [Validators.required, Validators.minLength(3), Validators.maxLength(100)]],
        editora: [null, [Validators.required, Validators.minLength(3), Validators.maxLength(100)]],
        edicao: [null, [Validators.required, Validators.minLength(3), Validators.maxLength(100)]],
        autor: [null, [Validators.required, Validators.minLength(3), Validators.maxLength(100)]],
      })
   }

  ngOnInit(): void {
  }

  novoCadastro () {
    if (this.formCadastro.valid){
      this.cadastroService.
      cadastroLivros (this.formCadastro.value).
      subscribe(() => {
        this.router.navigate([""]);
      }, erro => {
        alert("Não foi possível realizar o cadastro, tente novamente");});
    } else {
      alert ("Preencha os campos obrigatórios!");
    }
  }

}
