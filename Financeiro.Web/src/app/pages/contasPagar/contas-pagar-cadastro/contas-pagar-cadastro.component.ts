import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import {
  MAT_FORM_FIELD_DEFAULT_OPTIONS,
  MatFormFieldModule,
} from '@angular/material/form-field';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { provideNativeDateAdapter } from '@angular/material/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { Router, RouterModule } from '@angular/router';
import { FormularioComponent } from '../../../components/formulario/formulario.component';
import { ContasPagarService } from '../../../services/contas-pagar.service';
import { ContasPagar } from '../../../models/contasPagar';
@Component({
  selector: 'app-contas-pagar-cadastro',
  standalone: true,
  imports: [
    FontAwesomeModule,
    MatSelectModule,
    FormsModule,
    MatInputModule,
    MatFormFieldModule,
    CommonModule,
    ReactiveFormsModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule,
    FormularioComponent,
    CommonModule,
  ],
  providers: [
    {
      provide: MAT_FORM_FIELD_DEFAULT_OPTIONS,
      useValue: { appearance: 'outline' },
    },
    provideNativeDateAdapter(),
  ],
  templateUrl: './contas-pagar-cadastro.component.html',
  styleUrl: './contas-pagar-cadastro.component.css',
})
export class ContasPagarCadastroComponent {
  btnAcao = 'Cadastrar';
  btnTitulo = 'Cadastrar Conta a Pagar';
  constructor(
    private contaspagarservice: ContasPagarService,
    private router: Router
  ) {}

  createContasPagar(contaspagar: ContasPagar) {
    this.contaspagarservice.SaveContasPagar(contaspagar).subscribe((data) => {
      this.router.navigate(['/contaspagar']);
    });
  }
}
