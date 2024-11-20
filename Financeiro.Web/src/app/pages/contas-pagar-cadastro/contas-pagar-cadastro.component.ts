import {
  ChangeDetectionStrategy,
  Component,
  EventEmitter,
  OnInit,
  Output,
} from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseUIComponent } from '../../base-ui/base-ui.component';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import {
  MAT_FORM_FIELD_DEFAULT_OPTIONS,
  MatFormFieldModule,
} from '@angular/material/form-field';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
} from '@angular/forms';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { provideNativeDateAdapter } from '@angular/material/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { RepeticaoContaPagarEnum } from '../../enums/ContasPagarEnum';
import { ContasPagar } from '../../models/contasPagar';
import { RouterModule } from '@angular/router';
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
    MatDatepickerModule,
    MatDatepickerModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [
    {
      provide: MAT_FORM_FIELD_DEFAULT_OPTIONS,
      useValue: { appearance: 'outline' },
    },
    provideNativeDateAdapter(),
  ],

  changeDetection: ChangeDetectionStrategy.OnPush,
  templateUrl: './contas-pagar-cadastro.component.html',
  styleUrl: './contas-pagar-cadastro.component.css',
})
export class ContasPagarCadastroComponent implements OnInit {
  cadastroContasPagarForm!: FormGroup;

  @Output() onSubmit = new EventEmitter<ContasPagar>();

  valorTipoRepeticao: Array<string> = [];
  ngOnInit(): void {
    this.valorTipoRepeticao.push('Único', 'Parcelado', 'Fixo');

    this.cadastroContasPagarForm = new FormGroup({
      descricao: new FormControl(''),
      data_Emissao: new FormControl(''),
      data_Vencimento: new FormControl(''),
      dataAlteracao: new FormControl(''),
      pagamento: new FormControl(''),
      id: new FormControl(0),
      nome: new FormControl(''),
      valor: new FormControl(0),
      pagamentoParcial: new FormControl(''),
      valorPagamentoParcial: new FormControl(''),
      saldoDevedor: new FormControl(''),
      categoria: new FormControl(''),
      repeticao: new FormControl(''),
      qdadeRepeticao: new FormControl(''),
      observacoes: new FormControl(''),
      tags: new FormControl(''),
      status: new FormControl(''),
      status_Conta: new FormControl(''),
      corGrafico: new FormControl(''),
      conta: new FormControl(''),
    });
  }

  cancelar() {
    throw new Error('Method not implemented.');
  }

  selectContas = [
    'carteira',
    'conta bancaria',
    'vale alimentação',
    'vale refeição',
    'vale combustível',
    'vale geral',
  ];
  selectCategorias = ['Alimentação', 'Combustível', 'Lazer'];

  contasSelectRepeticao = Object.values(RepeticaoContaPagarEnum);
  selectRepeticaoContas = this.contasSelectRepeticao;

  closeModalCadastro() {
    const modalCadastro = document.getElementById('cadastrarContaPagar');
    if (modalCadastro != null) {
      modalCadastro.style.display = 'none';
    }
  }

  salvarDados() {
    //this.onSubmit.emit(this.cadastroContasPagarForm.value);
    console.log(this.cadastroContasPagarForm.value);
  }
}
