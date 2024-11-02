import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { ContasPagarComponent } from './pages/contas-pagar/contas-pagar.component';
import { NgModule } from '@angular/core';

export const routes: Routes = [
    {path: '', component:HomeComponent},
    {path: 'contaspagar', component:ContasPagarComponent},
];


@NgModule({
    imports:[RouterModule.forRoot(routes)],
    exports:[RouterModule]
})

export class AppRoutingModule { } 