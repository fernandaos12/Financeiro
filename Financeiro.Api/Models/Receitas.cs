using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
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
    [JsonConverter(typeof(TipoReceita))]
    public TipoReceita? TipoReceita { get; set; }

    [Column("TIPO_CONTA")]
    [Required]
    [JsonConverter(typeof(TipoConta))]
    public TipoConta? TipoConta { get; set; }

    [Column("MES_COMPETENCIA")]
    [Required]
    [JsonConverter(typeof(MesCompetencia))]
    public MesCompetencia? MesCompetencia { get; set; }
    
    [Column("VALIDADE")]
    [Required]
    public DateTime DataRecebimento { get; set; }
}
