import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
} from '@angular/forms';
import { RouterModule } from '@angular/router';
import { OutgoingMessage } from 'http';
import { ContasPagar } from '../../models/contasPagar';

@Component({
  selector: 'app-formulario',
  standalone: true,
  imports: [RouterModule, FormsModule, ReactiveFormsModule],
  templateUrl: './formulario.component.html',
  styleUrl: './formulario.component.css',
})
export class FormularioComponent implements OnInit {
  cadastroFormulario!: FormGroup;

  @Output() onSubmit = new EventEmitter<ContasPagar>();
  ngOnInit(): void {
    this.cadastroFormulario = new FormGroup({
      id: new FormControl(0),
      descricao: new FormControl(''),
      observacao: new FormControl(''),
      valor: new FormControl(0),
      situacao: new FormControl(true),
    });
  }

  salvar() {
    this.onSubmit.emit(this.cadastroFormulario.value);
  }
}
