import { LivrosComponent } from './livros.component';
import { CadastroComponent } from './cadastro/cadastro.component';
import { EditarComponent } from './editar/editar.component';
import { BuscarComponent } from './buscar/buscar.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  { path: '',
    component: LivrosComponent
  },
  { path: 'cadastro',
    component: CadastroComponent
  },
  { path: 'editar/:id',
    component: EditarComponent
  },
  { path: 'buscar',
    component: BuscarComponent
  },
];

export const LivrosRoutingRoutes = RouterModule.forChild(routes);
