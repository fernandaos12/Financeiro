import { Component } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { faCheck, faMagnifyingGlass, faCircleXmark } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-contas-pagar',
  standalone: true,
  imports: [FontAwesomeModule],
  templateUrl: './contas-pagar.component.html',
  styleUrl: './contas-pagar.component.css'
})
export class ContasPagarComponent {
faCheck = faCheck;
faCircleXmark = faCircleXmark;
faMagnifyingGlass = faMagnifyingGlass;

}
