using Financeiro.Domain.Entities;
using Financeiro.Domain.Enums;

namespace Financeiro.Domain.ValueObjects
{
    public record ContasPagarValue
    {
        public string? Descricao { get; set; }
        public StatusConta Status_Conta { get; set; } = StatusConta.Pendente;
        public DateTime Data_Vencimento { get; set; } = DateTime.Now;
        public double Valor { get; set; }
        public Categorias? Categoria { get; set; } = null;
        public int? CategoriaId { get; set; }
        public TipoRepeticao Repeticao { get; set; } = TipoRepeticao.UNICO;
        public int? Periodicidade { get; set; }
        public int? ValorParcela { get; set; }
        public int? NumeroParcelas { get; set; }
        public string? Observacoes { get; set; }
        public string? CaminhoAnexos { get; set; } = string.Empty;
        public byte[]? Anexos { get; set; }
        public int PagamentoId { get; set; }
        public Pagamento? Pagamento { get; set; }
    }
}
