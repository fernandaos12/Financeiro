namespace Financeiro.Domain.Services
{
    public class ContasPagarService
    {
        public ContasPagarService(string descricao, decimal valor, DateTime dataVencimento) : base()
        {
            descricao = Descricao ?? String.Empty;
            valor = Valor;
            dataVencimento = DataVencimento;
        }

        public string? Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataVencimento { get; private set; }
    }
}
