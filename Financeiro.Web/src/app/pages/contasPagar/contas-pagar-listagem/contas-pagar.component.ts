import {
  Component,
  OnInit,
  ChangeDetectionStrategy,
  CUSTOM_ELEMENTS_SCHEMA,
} from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import {
  faCheck,
  faMagnifyingGlass,
  faCircleXmark,
} from '@fortawesome/free-solid-svg-icons';

import { CommonModule } from '@angular/common';
import { MatSelectModule } from '@angular/material/select';
import { MAT_FORM_FIELD_DEFAULT_OPTIONS } from '@angular/material/form-field';
import { provideNativeDateAdapter } from '@angular/material/core';
import { Router, RouterModule } from '@angular/router';
import { ContasPagar } from '../../../models/contasPagar';
import { ContasPagarService } from '../../../services/contas-pagar.service';
import { NgxPaginationModule } from 'ngx-pagination';

@Component({
  selector: 'app-contas-pagar',
  standalone: true,
  imports: [
    FontAwesomeModule,
    MatSelectModule,
    CommonModule,
    RouterModule,
    NgxPaginationModule,
  ],
  providers: [
    {
      provide: MAT_FORM_FIELD_DEFAULT_OPTIONS,
      useValue: { appearance: 'outline' },
    },
    provideNativeDateAdapter(),
  ],

  // changeDetection: ChangeDetectionStrategy.OnPush,
  templateUrl: './contas-pagar.component.html',
  styleUrl: './contas-pagar.component.css',
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class ContasPagarComponent implements OnInit {
  totalRegistros: number = 0;
  cadastrarContaPagar: any;
  faCheck = faCheck;
  faCircleXmark = faCircleXmark;
  faMagnifyingGlass = faMagnifyingGlass;

  contaspagarlist: ContasPagar[] = [];
  contaspagarFiltrado: ContasPagar[] = [];
  public paginaAtual = 1;
  count: number = 0;
  currentIndex = -1;
  page = 1;

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
    //this.loadingService.show();
    // setTimeout(() => this.loadingService.hide(), 3000);

    this.ContasPagarService.GetContasPagar().subscribe((data) => {
      const dados = data.dadosRetorno;

      dados.map((item) => {
        let date = new Date(item.data_Vencimento);

        if (!isNaN(date.getTime())) {
          item.data_Vencimento = date.toLocaleDateString();
        } else {
          console.log('data invalida', date);
        }
      });

      this.contaspagarlist = dados;
      this.contaspagarFiltrado = dados;

      this.totalRegistros = this.contaspagarlist.length;
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
