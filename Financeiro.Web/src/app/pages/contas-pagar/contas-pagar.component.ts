import { Component, OnInit } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { faCheck, faMagnifyingGlass, faCircleXmark } from '@fortawesome/free-solid-svg-icons';
import { ContasPagarService } from '../../services/contas-pagar.service';
import { ContasPagar } from '../../models/contasPagar';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from "../../navbar/navbar.component";
import { BaseUIComponent } from "../../base-ui/base-ui.component";

@Component({
  selector: 'app-contas-pagar',
  standalone: true,
  imports: [
    FontAwesomeModule, 
    CommonModule, 
    NavbarComponent, 
    BaseUIComponent
  ],
  templateUrl: './contas-pagar.component.html',
  styleUrl: './contas-pagar.component.css'
})
export class ContasPagarComponent implements OnInit {
  cadastrarContaPagar: any;
  faCheck = faCheck;
  faCircleXmark = faCircleXmark;
  faMagnifyingGlass = faMagnifyingGlass;

  contaspagarlist : ContasPagar[] = [];
  contaspagarFiltrado : ContasPagar[] = [];
  
constructor(
  private ContasPagarService: ContasPagarService,
  
){}

openModalCadastro() {
  const modalCadastro = document.getElementById("cadastrarContaPagar");
  if(modalCadastro != null){
    modalCadastro.style.display = "block";
  }    
}
closeModalCadastro() {
  const modalCadastro = document.getElementById("cadastrarContaPagar");
  if(modalCadastro != null){
    modalCadastro.style.display = "none";
    }    
  }
  salvarDados() {
  throw new Error('Method not implemented.');
  }

  ngOnInit(): void {
    //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
    //Add 'implements OnInit' to the class.
    this.ContasPagarService.GetContasPagar().subscribe(data =>{
        const dados = data.dadosRetorno;

        dados.map((item)=>{
          item.data_Emissao = new Date(item.data_Emissao).toLocaleDateString();
          item.data_Vencimento = new Date(item.data_Vencimento).toLocaleDateString();
          item.dataAlteracao = new Date(item.dataAlteracao).toLocaleDateString();
        })

        this.contaspagarlist = dados;
        this.contaspagarFiltrado = dados; 
      });
  }
  search($event: Event) {
    const target = $event.target as HTMLInputElement;
    const value = target.value;

    this.contaspagarlist = this.contaspagarFiltrado.filter(contaspagarlist =>{
      return contaspagarlist.descricao.toLowerCase().includes(value.toLowerCase()) 
    } )
  }
}
