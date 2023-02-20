import { LivrosComponent } from './livros.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  { path: '',
    component: LivrosComponent
  },
];

export const LivrosRoutingRoutes = RouterModule.forChild(routes);
