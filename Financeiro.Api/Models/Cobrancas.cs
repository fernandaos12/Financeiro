using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Api.Models.Base;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Api.Models;
[Table("TB_COBRANCA")]
public class Cobrancas : BaseModel
{
    [Column("DESCRICAO")]  
    [Required]
    [StringLength(maximumLength:500,ErrorMessage = "Esse campo é obrigatório")]
    public string? Descricao {get;set;}

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

    [Required]
    [Column("NEGOCIA_DIVIDA")]
    public bool NegociaDivida { get; set; }
    
    [Column("NEGOCIACAO")]
    [ForeignKey("ID_NEGOCIACAO")]
    public Cobranca_Negociacao? NegociacaoDivida { get; set; }

    [Column("VENCIMENTO")]
    [DataType(DataType.Date)]
    public DateTime? Vencimento { get; set; }
}
