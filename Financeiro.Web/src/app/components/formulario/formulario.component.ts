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
  selectedFile: any;
  nomeArquivoAnexo: string = 'AnexoContaPagar';
  anexoArquivo: any = [];

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
      caminhoAnexos: new FormControl(this.nomeArquivoAnexo),
      anexos: new FormControl(
        this.dadosContasPagar?.anexos ? this.dadosContasPagar.anexos : ''
      ),
    });
  }

  uploadFile(event: any) {
    if (event.target.files.length > 0) {
      const arquivo = event.target.files[0];
      if (arquivo) {
        // const caminhoArquivo = arquivo.name.replace('C:\\fakepath\\', '');
        // this.contasForm.patchValue({ caminhoAnexos: caminhoArquivo }); //retira o fakepath do caminho do arquivo

        const reader = new FileReader();

        reader.onload = () => {
          const arrayBuffer = reader.result as ArrayBuffer;
          const bytes = new Uint8Array(arrayBuffer);
          console.log(bytes);
          arquivo.setValue(bytes);
          this.contasForm.patchValue({ anexos: arquivo });
        };
        reader.readAsArrayBuffer(arquivo);
      }
    }
  }

  loadingCategorias() {
    this.categoriasService.GetSelectCategorias().subscribe((result: any) => {
      this.categorias = result.dadosRetorno;
    });
  }

  salvar() {
    console.log(this.contasForm.value);
    this.onSubmit.emit(this.contasForm.value);

    // var file = this.contasForm.controls['anexos'].value.files[''];
    // console.log(file);
    // var reader = new FileReader();
    // var fileByteArray : any[] = [];

    // reader.readAsArrayBuffer(this.formGroup.controls.anexos.value.files[0]);

    // reader.onloadend = function (evt: any) {

    // if (evt.target.readyState == FileReader.DONE) {

    // var arrayBuffer = <any>evt.target.result;

    // var array = new Uint8Array(arrayBuffer);

    // for (var i = 0; i < array.length; i++) {

    // fileByteArray.push(array[i]);
  }
}
