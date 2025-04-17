using Financeiro.Api.Models.Base;

namespace Financeiro.Domain.Entities;

public class Cobrancas : BaseModel
{
    public string? Descricao { get; set; }
    public Pagamento? Pagamento { get; set; }
    public Categorias? CategoriaDivida { get; set; }
    public double? Valor { get; set; }
    public bool NegociaDivida { get; set; }
    public Cobranca_Negociacao? NegociacaoDivida { get; set; }
    public DateTime? Vencimento { get; set; }
    public string? CorGrafico { get; set; }

}
