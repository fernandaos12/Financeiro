using Financeiro.Domain.Abstractions;

namespace Financeiro.Domain.Entities;

public class CartaoCreditoDTO : Entity
{
    public string? Descricao { get; set; }
    public int NumeroCartao { get; set; }
    public DateTime Validade { get; set; }
    public int NomeNoCartao { get; set; }
    public ContaBancaria? Banco { get; set; }
    public double LimiteTotal { get; set; }
    public double LimiteUtilizado { get; set; }
    public DateTime DataFechamento { get; set; }

}
