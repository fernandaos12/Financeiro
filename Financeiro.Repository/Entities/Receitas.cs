using Financeiro.Domain.Abstractions;
using Financeiro.Domain.Enums;

namespace Financeiro.Domain.Entities;

public class Receitas : Entity
{
    public string? Descricao { get; set; }
    public TipoReceita? TipoReceita { get; set; }
    public FormaPagamentoEnum? TipoConta { get; set; }
    public double Valor { get; set; }
    public MesCompetencia? MesCompetencia { get; set; }
    public DateTime DataRecebimento { get; set; }
    public String? CaminhoAnexos { get; set; } = String.Empty;
    public Byte[]? Anexos { get; set; }
    public List<string> Tags { get; set; } = new List<string>();
}
