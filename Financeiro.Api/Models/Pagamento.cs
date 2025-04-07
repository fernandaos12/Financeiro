using Financeiro.Api.Models.Base;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Api.Models
{
    public class Pagamento : BaseModel
    {
        public string? Descricao { get; set; }
        public MesCompetencia? MesCompetencia { get; set; }
        public TipoConta FormaPagamento { get; set; }
        public bool PagamentoParcial { get; set; } = false;
        public double ValorPagamentoParcial { get; set; } = 0;
        public double Valor { get; set; } = 0;
        public StatusConta StatusPagamento { get; set; }
        public double SaldoDevedor { get; set; } = 0;
        public ICollection<ContasPagar> ContasPagar { get; set; } = new List<ContasPagar>();
        public DateTime DataPagamento { get; set; }
    }
}