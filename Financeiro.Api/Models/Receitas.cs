using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Api.Models.Base;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Api.Models;

[Table("TB_RECEITAS")]
public class Receitas : BaseModel
{
    [Column("DESCRICAO")]
    [Required]
    public string? Descricao { get; set; }

    [Column("TIPO_RECEITA")]
    [Required]
    [EnumDataType(typeof(TipoReceita))]
    public TipoReceita? TipoReceita { get; set; }

    [Column("TIPO_CONTA")]
    [Required]
    [EnumDataType(typeof(TipoConta))]
    public TipoConta? TipoConta { get; set; }

    [Column("VALOR")]
    public double Valor { get; set; }

    [Column("MES_COMPETENCIA")]
    [Required]
    [EnumDataType(typeof(MesCompetencia))]
    public MesCompetencia? MesCompetencia { get; set; }

    [Column("VALIDADE")]
    [Required]
    public DateTime DataRecebimento { get; set; }

    [Column("CAMINHO_ANEXOS")]
    public String? CaminhoAnexos { get; set; } = String.Empty;

    [Column("ANEXOS")]
    public Byte[]? Anexos { get; set; }

}
