using Financeiro.Domain.Abstractions;

namespace Financeiro.Domain.Entities;

public class Cobranca_Negociacao : Entity
{
    public string Descricao { get; set; } = string.Empty;
    public double Valor { get; set; } = 0.00;
    public DateTime? Vencimento { get; set; } = DateTime.Now;
    public bool? Parcelado { get; set; }
    public int? QdadeParcelas { get; set; }

}
