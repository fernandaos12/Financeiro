using Financeiro.Domain.Abstractions;
using Financeiro.Domain.Enums;

namespace Financeiro.Domain.Entities
{
    public class Pagamento : Entity
    {
        public string? Descricao { get; set; }
        public MesCompetencia? MesCompetencia { get; set; }
        public FormaPagamentoEnum FormaPagamento { get; set; }
        public bool PagamentoParcial { get; set; } = false;
        public double ValorPagamentoParcial { get; set; } = 0;
        public double Valor { get; set; } = 0;
        public StatusConta StatusPagamento { get; set; }
        public double SaldoDevedor { get; set; } = 0;
        public ICollection<ContasPagar> ContasPagar { get; set; } = new List<ContasPagar>();
        public DateTime DataPagamento { get; set; }
        public double ValorPagamentoTotal { get; set; }
        public DateTime DataVencimento { get; set; }
        public string? Observacao { get; set; }

        public void ValorPagamento(double valor, DateTime dataPagamento)
        {
            double valorCalculado = valor;
            double multa = 0.2;
            double juros = 0.1;

            if (dataPagamento > DateTime.Now)
            {
                valorCalculado += (valor * juros) + (valor * multa);
            }

            ValorPagamentoTotal = valorCalculado;
        }
    }

}