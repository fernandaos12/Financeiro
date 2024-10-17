using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Api.Models.Base;

namespace Financeiro.Api.Models;

[Table("TB_TAGS")]
public class Tags : BaseModel
{
    [Column("DESCRICAO")]
    public string? Descricao { get; set; }

    [Column("ID_CONTA_PAGAR")]
    [ForeignKey("ID_CONTAPAGAR")]
    public ContasPagar? Id_ContaPagar { get; set; }
}
