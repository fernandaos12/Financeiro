using Financeiro.Domain.Abstractions;

namespace Financeiro.Domain.Entities;

public class Cobranca_Negociacao : Entity
{
    public string? Descricao { get; set; }
    public Pagamento? Pagamento { get; set; }
    public Categorias? CategoriaDivida { get; set; }
    public double? Valor { get; set; }
    public DateTime? Vencimento { get; set; }
    public bool? Parcelado { get; set; }
    public int? QdadeParcelas { get; set; }

}
