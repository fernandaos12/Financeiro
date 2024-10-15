import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ContasPagarComponent } from "./pages/contas-pagar/contas-pagar.component";
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';



@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet, 
    ContasPagarComponent,
		FontAwesomeModule
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Financeiro.Web';
}
