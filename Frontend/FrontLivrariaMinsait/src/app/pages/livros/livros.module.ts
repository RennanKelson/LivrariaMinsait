import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EditarComponent } from './editar/editar.component';
import { CadastroComponent } from './cadastro/cadastro.component';
import { LivrosRoutingRoutes } from './livros-routing.routing';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    EditarComponent,
    CadastroComponent
  ],
  imports: [
    CommonModule,
    LivrosRoutingRoutes,
    FormsModule,
  ]
})
export class LivrosModule { }
