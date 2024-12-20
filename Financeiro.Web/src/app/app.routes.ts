import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { ContasPagarComponent } from './pages/contasPagar/contas-pagar-listagem/contas-pagar.component';
import { ContasPagarCadastroComponent } from './pages/contasPagar/contas-pagar-cadastro/contas-pagar-cadastro.component';
import { ContaspagareditarComponent } from './pages/contasPagar/contaspagareditar/contaspagareditar.component';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'contaspagar', component: ContasPagarComponent },
  { path: 'contaspagarcadastro', component: ContasPagarCadastroComponent },
  { path: 'contaspagareditar/:id', component: ContaspagareditarComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
