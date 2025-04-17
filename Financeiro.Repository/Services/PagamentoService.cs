namespace Financeiro.Domain.Services
{
    public class PagamentoService
    {
        public string Descricao { get; private set; }
        public decimal ValorPagamento { get; private set; }
        public DateTime DataPagamento { get; private set; } = DateTime.Now;
        public DateTime DataVencimento { get; private set; }

        public PagamentoService(string descricao, decimal valorPagamento, DateTime dataPagamento, DateTime dataVencimento)
        {
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            ValorPagamento = valorPagamento;
            DataPagamento = dataPagamento;
            DataVencimento = dataVencimento;
        }

        public static object PagamentoFinal(PagamentoService pgto)
        {
            throw new NotImplementedException();
        }
    }
}
