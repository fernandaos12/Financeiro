using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Api.Models.Base;

namespace Financeiro.Api.Models;

[Table("TB_TAGS")]
public class Tags : BaseModel
{
    [Column("DESCRICAO")]
    public string? Descricao { get; set; }
}
