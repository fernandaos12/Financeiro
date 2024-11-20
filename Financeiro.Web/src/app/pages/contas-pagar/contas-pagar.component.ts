import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import {
  faCheck,
  faMagnifyingGlass,
  faCircleXmark,
} from '@fortawesome/free-solid-svg-icons';
import { ContasPagarService } from '../../services/contas-pagar.service';
import { ContasPagar } from '../../models/contasPagar';
import { CommonModule } from '@angular/common';
import { MatSelectModule } from '@angular/material/select';
import { MAT_FORM_FIELD_DEFAULT_OPTIONS } from '@angular/material/form-field';
import { provideNativeDateAdapter } from '@angular/material/core';
import { Router } from '@angular/router';
import { ContasPagarCadastroComponent } from '../contas-pagar-cadastro/contas-pagar-cadastro.component';

@Component({
  selector: 'app-contas-pagar',
  standalone: true,
  imports: [
    FontAwesomeModule,
    MatSelectModule,
    CommonModule,
    ContasPagarCadastroComponent,
  ],
  providers: [
    {
      provide: MAT_FORM_FIELD_DEFAULT_OPTIONS,
      useValue: { appearance: 'outline' },
    },
    provideNativeDateAdapter(),
  ],

  changeDetection: ChangeDetectionStrategy.OnPush,
  templateUrl: './contas-pagar.component.html',
  styleUrl: './contas-pagar.component.css',
})
export class ContasPagarComponent implements OnInit {
  cadastrarContaPagar: any;
  faCheck = faCheck;
  faCircleXmark = faCircleXmark;
  faMagnifyingGlass = faMagnifyingGlass;

  contaspagarlist: ContasPagar[] = [];
  contaspagarFiltrado: ContasPagar[] = [];

  constructor(
    private ContasPagarService: ContasPagarService,
    private router: Router
  ) {}

  openModalCadastro() {
    const modalCadastro = document.getElementById('cadastrarContaPagar');
    if (modalCadastro != null) {
      modalCadastro.style.display = 'block';
    }
  }
  closeModalCadastro() {
    const modalCadastro = document.getElementById('cadastrarContaPagar');
    if (modalCadastro != null) {
      modalCadastro.style.display = 'none';
    }
  }

  ngOnInit(): void {
    this.ContasPagarService.GetContasPagar().subscribe((data) => {
      const dados = data.dadosRetorno;

      dados.map((item) => {
        item.data_Emissao = new Date(item.data_Emissao).toLocaleDateString();
        item.data_Vencimento = new Date(
          item.data_Vencimento
        ).toLocaleDateString();
        item.dataAlteracao = new Date(item.dataAlteracao).toLocaleDateString();
      });

      this.contaspagarlist = dados;
      this.contaspagarFiltrado = dados;
    });
  }
  search($event: Event) {
    const target = $event.target as HTMLInputElement;
    const value = target.value;

    this.contaspagarlist = this.contaspagarFiltrado.filter(
      (contaspagarlist) => {
        return contaspagarlist.descricao
          .toLowerCase()
          .includes(value.toLowerCase());
      }
    );
  }
  criarContaPagar(contaspagar: ContasPagar) {
    this.ContasPagarService.SaveContasPagar(contaspagar).subscribe(
      (response) => {
        this.router.navigate(['/contas-pagar']);
        console.log(response);
      }
    );
  }
}
