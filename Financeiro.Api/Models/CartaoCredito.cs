using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Api.Models.Base;

namespace Financeiro.Api.Models;

[Table("TB_CARTAO_CREDITO")]
public class CartaoCredito : BaseModel
{
    [Column("DESCRICAO")]
    [Required]
    public string? Descricao { get; set; }

    [Column("NUMERO_CARTAO")]
    [Required]
    public int NumeroCartao { get; set; }
    
    [Column("VALIDADE")]
    [Required]
    public DateTime Validade { get; set; }
    
    [Column("NOME_NOCARTAO")]
    [Required]
    public int NomeNoCartao { get; set; }
    
    [Column("BANCO")]
    [Required]
    [ForeignKey("ID")]
    public ContaBancaria? Banco { get; set; }

    [Column("LIMITE_TOTAL")]
    [Required]
    public double LimiteTotal { get; set; }

    [Column("LIMITE_UTILIZADO")]
    [Required]
    public double LimiteUtilizado { get; set; }

}
