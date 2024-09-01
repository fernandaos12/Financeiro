using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Api.Models.Base;

namespace Financeiro.Api.Models;

[Table("TB_CONTA_BANCARIA")]
public class ContaBancaria : BaseModel
{
    [Column("DESCRICAO")]
    [Required]
    public string? Descricao { get; set; }

    [Column("CONTA")]
    [Required]
    public int Conta { get; set; }
    
    [Column("AGENCIA")]
    [Required]
    public int Agencia { get; set; }
    
    [Column("DIGITO")]
    [Required]
    public int Digito { get; set; }
    
    [Column("OBSERVACOES")]
    [Required]
    public string? Observacoes { get; set; }

    [Column("SALDO")]
    [Required]
    public double SaldoTotal { get; set; }

    [Column("SALDO_UTILIZADO")]
    [Required]
    public double SaldoUtilizado { get; set; }

}
