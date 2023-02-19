import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EditarComponent } from './editar/editar.component';
import { CadastroComponent } from './cadastro/cadastro.component';



@NgModule({
  declarations: [
    EditarComponent,
    CadastroComponent
  ],
  imports: [
    CommonModule
  ]
})
export class LivrosModule { }
