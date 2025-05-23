using Financeiro.Domain.Abstractions;
using Financeiro.Domain.Enums;

namespace Financeiro.Domain.Entities;

public class Cobrancas : Entity
{
    public string Descricao { get; set; } = String.Empty;
    public Pagamento? Pagamento { get; set; }
    public int? PagamentoId { get; set; }
    public bool Pago { get; set; } = false;
    public TipoCategoria CategoriaDivida { get; set; }
    public double? Valor { get; set; }
    public DateTime Vencimento { get; set; } = DateTime.Now;
    public bool DividaNegociada { get; set; } = false;
    public Cobranca_Negociacao? Negociacao { get; set; }
    public int? NegociacaoId { get; set; }
    public string? CorGrafico { get; set; }

}
