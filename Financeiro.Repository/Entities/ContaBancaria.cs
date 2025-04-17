using Financeiro.Domain.Abstractions;

namespace Financeiro.Domain.Entities;

public class ContaBancaria : Entity
{
    public string? Descricao { get; set; }
    public int Conta { get; set; }
    public int Agencia { get; set; }
    public int Digito { get; set; }
    public string? Observacoes { get; set; }
    public double SaldoTotal { get; set; }
    public double SaldoUtilizado { get; set; }

}
