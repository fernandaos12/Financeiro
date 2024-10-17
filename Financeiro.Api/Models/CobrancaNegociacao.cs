
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Financeiro.Api.Models.Base;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Api.Models;

[Table("TB_NEGOCIACAO")]
public class Cobranca_Negociacao : BaseModel
{
    [Required]
    [StringLength(maximumLength:500)]
    [Column("DESCRICAO")]
    public string? Descricao { get; set; }

    [Column("PAGAMENTO")]
    [ForeignKey("ID_PAGAMENTO")]
    public Pagamento? Pagamento { get; set; }

    [Required]
    [Column("ID_CATEGORIA")]
    [ForeignKey("ID_CATEGORIA")]
    public Categorias? CategoriaDivida { get; set; }
    
    [Required]
    [Column("VALOR")]
    public double? Valor { get; set; }

    [Column("VENCIMENTO")]
    [DataType(DataType.Date)]
    public DateTime? Vencimento { get; set; }

    [Required]
    [Column("PARCELADO")]
    public bool? Parcelado { get; set; }

    [Column("QDADE_PARCELAS")]
    public int? QdadeParcelas { get; set; }

}
