using Financeiro.Api.Models.Base;

namespace Financeiro.Api.Models;

public class ContaBancaria : BaseModel
{
    public string? Descricao { get; set; }
    public int Conta { get; set; }
    public int Agencia { get; set; }
    public int Digito { get; set; }
    public string? Observacoes { get; set; }
    public double SaldoTotal { get; set; }
    public double SaldoUtilizado { get; set; }

}
