import { Component } from '@angular/core';
import { Chart, registerables } from 'chart.js';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { CommonModule } from '@angular/common';
import { faChartLine, faCircleDollarToSlot, faClock, faHandHoldingDollar } from '@fortawesome/free-solid-svg-icons';

Chart.register(...registerables);
@Component({
  selector: 'app-home',
  standalone: true,
  imports: [FontAwesomeModule,CommonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  //icones
  faHandHoldingDollar = faHandHoldingDollar;
  faChartLine = faChartLine;
  faCircleDollarToSlot = faCircleDollarToSlot;
  faClock = faClock;

  //graficos
  public doughnutChart_ContasPagar: any;
  public doughnutChart_Metas: any;

  constructor() {
    this.doughnutChart_ContasPagar = new Chart('doughnutChart_ContasPagar', {
      type: 'doughnut',
      data: {
        labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
        datasets: [{
          label: 'Gráfico Contas a Pagar do mês',
          data: [300, 50, 100, 40, 120, 60],
          backgroundColor: [
            'rgba(255, 99, 132)',
            'rgba(54, 162, 235)',
            'rgba(255, 206, 86)',
            'rgba(75, 192, 192)',
            'rgba(153, 102, 255)',
            'rgba(255, 159, 64)'
          ],         
          borderWidth: 0
        }]
      },
      options: {
        responsive: true,
        plugins: {
          legend: {
            position: 'left',
          },
          title: {
            display: true,
            text: 'Contas a Pagar do mês'
          }
        }
      }
    });

    //grafico de metas
    this.doughnutChart_Metas = new Chart('doughnutChart_Metas', {
      type: 'doughnut',
      data: {
        labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
        datasets: [{
          label: 'Gráfico Metas definidas',
          data: [300, 50, 100, 40, 120, 60],
          backgroundColor: [
            'rgba(255, 99, 132)',
            'rgba(54, 162, 235)',
            'rgba(255, 206, 86)',
            'rgba(75, 192, 192)',
            'rgba(153, 102, 255)',
            'rgba(255, 159, 64)'
          ],         
          borderWidth: 0
        }]
      },
      options: {
        responsive: true,
        plugins: {
          legend: {
            position: 'left',
          },
          title: {
            display: true,
            text: 'Metas'
          }
        }
      }
    });
  }

}
