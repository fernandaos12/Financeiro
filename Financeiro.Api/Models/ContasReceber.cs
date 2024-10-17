
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Financeiro.Api.Models.Base;
using Financeiro.Api.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Models
{
    [Table("TB_CONTAS_RECEBER")]
    public class ContasReceber : BaseModel
    {
        [Column("VALOR")]
        [Required]
        public double Valor { get; set; }
         
        [Column("VENCIMENTO")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DataVencimento { get; set; }
                
        [Column("REPETICAO")]
        [Required]
        public bool Repeticao { get; set; }
        
        [Column("CONFIRMADO")]
        public bool Confirmado { get; set; }
        
        [Column("CONCILIADO")]
        [Required]
        public bool Conciliado { get; set; }
        
        [Column("QDADE_REPETICOES")]
        public int QdadeRepeticoes { get; set; }
        
        [Column("DESCRICAO")]         
        [Required]
        [StringLength(maximumLength:500,ErrorMessage ="Campo Descrição obrigatório")]
        public string? Descricao { get; set; }
        
        [Column("CONTA")]
        [EnumDataType(typeof(TipoConta))]
        public TipoConta? Conta { get; set; } //se a conta é de cartao de credito
         
        [Column("ID_CATEGORIAS")]
        public Categorias? Categoria { get; set; }
        
        [Column("OBSERVACOES")]
        public string? Observacoes { get; set; }
        
        [Column("TAGS")]
        [ForeignKey("ID_TAGS")]
        public List<Tags>? Tags { get; set; }
    }
}