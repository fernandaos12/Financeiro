import { Component, OnInit } from '@angular/core';
import { Chart, registerables, DoughnutController } from 'chart.js/auto';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { CommonModule } from '@angular/common';
import { faChartLine, faCircleDollarToSlot, faClock, faHandHoldingDollar } from '@fortawesome/free-solid-svg-icons';
import { GraficosService } from '../../services/graficos.service';

// Chart.register(...registerables);
// Chart.register(DoughnutController);
@Component({
  selector: 'app-home',
  standalone: true,
  imports: [FontAwesomeModule,CommonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit {
  //icones
  faHandHoldingDollar = faHandHoldingDollar;
  faChartLine = faChartLine;
  faCircleDollarToSlot = faCircleDollarToSlot;
  faClock = faClock;
  
  //graficos
  public doughnutChart_ContasPagar: any;
  public doughnutChart_Metas: any;
  public graficoContasPagar: any;
  private chartInfo: any;
  private labelCategoriaConta: any[] = [];
  private valorConta: any[] = [];
  private colordata: any[] = [];
    constructor(public service: GraficosService) {
    }
    
    ngOnInit(): void {
      //service graficos
      this.service.GetContasPagarGraficos().subscribe((response) => {
        this.chartInfo = response.dadosRetorno;

        if (this.chartInfo != null) {
          for (let i = 0; i < this.chartInfo.length; i++) {
            this.labelCategoriaConta.push(this.chartInfo[i].descricao);
            this.valorConta.push(this.chartInfo[i].valor);
            this.colordata.push(this.chartInfo[i].corGrafico);          
        }
      }
          this.createChart(this.labelCategoriaConta, this.valorConta, this.colordata);        
     });
    }

    createChart(labelCategoriaConta: any, valorConta: any, colordata: any) {
      this.graficoContasPagar = new Chart("doughnutChart_ContasPagar", {
        type: 'doughnut',
        data: {
          labels: labelCategoriaConta,
          datasets: [
            {
              label: labelCategoriaConta,
              data: valorConta,
              backgroundColor: colordata,
            }, 
          ]
        },
        options: {          
          aspectRatio: 0,
          hoverBorderColor: '#000',
          responsive: true,
          plugins: {
            tooltip: {
              enabled: false,
            },
            legend: {
              position: 'left',
            },
            title: {
              display: true,
              text: 'Contas a Pagar do mês'
            }
          },
        },
      });
    }
}

