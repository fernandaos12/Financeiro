import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { RouterModule } from '@angular/router';
import { ContasPagar, TipoRepeticao } from '../../models/contasPagar';
import { CommonModule } from '@angular/common';
import { CategoriaServiceService } from '../../services/categoria-service.service';

@Component({
  selector: 'app-formulario',
  standalone: true,
  imports: [RouterModule, FormsModule, ReactiveFormsModule, CommonModule],
  templateUrl: './formulario.component.html',
  styleUrl: './formulario.component.css',
})
export class FormularioComponent implements OnInit {
  @Output() onSubmit = new EventEmitter<ContasPagar>();
  @Input() btnAcao!: string;
  @Input() btnTitulo!: string;
  @Input() dadosContasPagar: ContasPagar | null = null;

  contasForm!: FormGroup;
  formGroup: any;
  selectedOption: any;
  options: any = [];
  categorias: any[] = [];
  categoriaId: string = '';
  tiposrepeticao = Object.values(TipoRepeticao);

  constructor(private categoriasService: CategoriaServiceService) {}

  ngOnInit(): void {
    this.loadingCategorias();

    this.contasForm = new FormGroup({
      id: new FormControl(
        this.dadosContasPagar?.id ? this.dadosContasPagar.id : 0
      ),
      descricao: new FormControl(
        this.dadosContasPagar?.descricao ? this.dadosContasPagar.descricao : '',
        Validators.required
      ),
      dataAlteracao: new FormControl(new Date()),
      status_Conta: new FormControl(
        this.dadosContasPagar?.status_Conta
          ? this.dadosContasPagar.status_Conta
          : '',
        Validators.required
      ),
      data_Vencimento: new FormControl(
        this.dadosContasPagar?.data_Vencimento
          ? this.dadosContasPagar.data_Vencimento
          : '',
        Validators.required
      ),
      valor: new FormControl(
        this.dadosContasPagar?.valor ? this.dadosContasPagar.valor : 0,
        Validators.required
      ),
      categoriaId: new FormControl(
        this.dadosContasPagar?.categoriaId
          ? this.dadosContasPagar.categoriaId
          : 0,
        Validators.required
      ),
      repeticao: new FormControl(
        this.dadosContasPagar?.repeticao ? this.dadosContasPagar.repeticao : 0,
        Validators.required
      ),
      periodicidade: new FormControl(
        this.dadosContasPagar?.periodicidade
          ? this.dadosContasPagar.periodicidade
          : 0,
        Validators.required
      ),
      valorParcela: new FormControl(
        this.dadosContasPagar?.valorParcela
          ? this.dadosContasPagar.valorParcela
          : 0
      ),
      numeroParcelas: new FormControl(
        this.dadosContasPagar?.numeroParcelas
          ? this.dadosContasPagar.numeroParcelas
          : 0
      ),
      observacoes: new FormControl(
        this.dadosContasPagar?.observacoes
          ? this.dadosContasPagar.observacoes
          : ''
      ),
      anexos: new FormControl(
        this.dadosContasPagar?.anexos ? this.dadosContasPagar.anexos : ''
      ),
    });
  }
  loadingCategorias() {
    this.categoriasService.GetSelectCategorias().subscribe((result: any) => {
      this.categorias = result.dadosRetorno;
    });
  }

  salvar() {
    //console.log(this.contasForm.value);
    this.onSubmit.emit(this.contasForm.value);
  }
}
