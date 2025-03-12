using Financeiro.Api.Models;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Teste.Models
{
    public class ContasPagarTesteModel
    {
        public string? Descricao { get; set; }
        public StatusConta Status_Conta { get; set; } = StatusConta.Pendente;
        public DateTime Data_Vencimento { get; set; } = DateTime.Now;
        public double Valor { get; set; }
        public CategoriaReceitas? Categoria { get; set; }
        public int? CategoriaId { get; set; }
        public TipoRepeticao Repeticao { get; set; } = TipoRepeticao.UNICO;
        public int? Periodicidade { get; set; }
        public int? ValorParcela { get; set; }
        public int? NumeroParcelas { get; set; }
        public string? Observacoes { get; set; }
        public String? CaminhoAnexos { get; set; } = String.Empty;
        public Byte[]? Anexos { get; set; }
        public int PagamentoId { get; set; }
        public Pagamento? Pagamento { get; set; }
    }
}
