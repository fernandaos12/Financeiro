using Financeiro.Api.Models.Base;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Domain.Entities;

public class Receitas : BaseModel
{
    public string? Descricao { get; set; }
    public TipoReceita? TipoReceita { get; set; }
    public TipoConta? TipoConta { get; set; }
    public double Valor { get; set; }
    public MesCompetencia? MesCompetencia { get; set; }
    public DateTime DataRecebimento { get; set; }
    public String? CaminhoAnexos { get; set; } = String.Empty;
    public Byte[]? Anexos { get; set; }
    public List<string> Tags { get; set; } = new List<string>();
}
