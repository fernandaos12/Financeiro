namespace Financeiro.Domain.ValueObjects
{
    public class PagamentoValue
    {
        public PagamentoValue(string descricao, decimal valor, DateTime dataPagamento, DateTime dataVencimento)
        {
            descricao = Descricao;
            valor = Valor;
            dataPagamento = DataPagamento;
            dataVencimento = DataVencimento;
        }

        public decimal Valor { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataPagamento { get; private set; } = DateTime.Now;
        public DateTime DataVencimento { get; private set; }
    }
}
