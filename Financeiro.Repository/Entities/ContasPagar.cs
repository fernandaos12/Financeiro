using Financeiro.Domain.Abstractions;
using Financeiro.Domain.Enums;

namespace Financeiro.Domain.Entities
{
    public class ContasPagar : Entity
    {
        public string? Descricao { get; set; }
        public StatusConta Status_Conta { get; set; } = StatusConta.Pendente;
        public DateTime Data_Vencimento { get; set; } = DateTime.Now;
        public double Valor { get; set; }
        public double ValorPago { get; set; }
        public TipoCategoria Categoria { get; set; }
        public TipoRepeticao Repeticao { get; set; } = TipoRepeticao.UNICO;
        public int? Periodicidade { get; set; }
        public int? ValorParcela { get; set; }
        public int? NumeroParcelas { get; set; }
        public string? Observacoes { get; set; }
        public String? CaminhoAnexos { get; set; } = String.Empty;
        public Byte[]? Anexos { get; set; }
        public int PagamentoId { get; set; }
        public Pagamento? Pagamento { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public double SaldoDevedorAtualizado { get; set; }

        public void SaldoDevedor(double valorDivida, double valorPago)
        {
            double saldoDevedor = 0.0;
            var ValorTotal = valorDivida;

            if (ValorTotal < valorDivida)
            {
                saldoDevedor = valorDivida - valorPago;
            }
            SaldoDevedorAtualizado = saldoDevedor;
        }

    }
}