import { Component, OnInit } from '@angular/core';
import { FormularioComponent } from '../../../components/formulario/formulario.component';
import { ContasPagar } from '../../../models/contasPagar';
import { ContasPagarService } from '../../../services/contas-pagar.service';
import { ActivatedRoute, Router } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-contaspagareditar',
  standalone: true,
  imports: [FormularioComponent, CommonModule],
  templateUrl: './contaspagareditar.component.html',
  styleUrl: './contaspagareditar.component.css',
})
export class ContaspagareditarComponent implements OnInit {
  btnAcao: string = 'Editar';
  btnTitulo: string = 'Editar Conta a Pagar';
  contaPagar!: ContasPagar;

  constructor(
    private contaspagarservice: ContasPagarService,
    private router: ActivatedRoute,
    private route: Router
  ) {}
  ngOnInit(): void {
    const id = Number(this.router.snapshot.paramMap.get('id'));
    this.contaspagarservice
      .GetContaPagar(id)
      .subscribe((data) => (this.contaPagar = data.dadosRetorno));
  }

  atualizarContaPagar(contapagar: ContasPagar) {
    this.contaspagarservice.UpdateContasPagar(contapagar).subscribe((data) => {
      this.route.navigate(['/contaspagar']);
    });
  }
}
