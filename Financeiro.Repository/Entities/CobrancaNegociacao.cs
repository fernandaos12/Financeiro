using Financeiro.Api.Models.Base;

namespace Financeiro.Domain.Entities;

public class Cobranca_Negociacao : BaseModel
{
    public string? Descricao { get; set; }
    public Pagamento? Pagamento { get; set; }
    public Categorias? CategoriaDivida { get; set; }
    public double? Valor { get; set; }
    public DateTime? Vencimento { get; set; }
    public bool? Parcelado { get; set; }
    public int? QdadeParcelas { get; set; }

}
