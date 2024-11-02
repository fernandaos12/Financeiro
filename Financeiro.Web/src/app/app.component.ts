import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ContasPagarComponent } from "./pages/contas-pagar/contas-pagar.component";
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { NavbarComponent } from "./navbar/navbar.component";
import { BaseUIComponent } from "./base-ui/base-ui.component";
import { FooterComponent } from "./footer/footer.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    ContasPagarComponent,
    FontAwesomeModule,
    NavbarComponent,
    BaseUIComponent,
    FooterComponent,
    
],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Financeiro.Web';
}
