using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Api.Models.Base;

namespace Financeiro.Api.Models
{
    [Table("TB_CONTAS_PAGAR")]
    public class ContasPagar : BaseModel
    {
        [Column("DESCRICAO")]
        [Required]
        [StringLength(maximumLength:500,ErrorMessage ="Campo Descrição obrigatório")]
        public string? Descricao { get; set; }
        
        [Column("EMISSAO")]
        [Required]
        public DateTime Data_Emissao { get; set; }
        
        [Column("VENCIMENTO")]
        [Required]
        public DateTime Data_Vencimento { get; set; }
        
        [Column("PAGAMENTO")]
        [ForeignKey("ID")]
        public Pagamento? Pagamento { get; set; }
        
        [Column("VALOR")]
        public double Valor { get; set; }
        
        [Column("CATEGORIA")]
        [ForeignKey("ID")]
        public Categorias? Categoria { get; set; }
        
        [Column("REPETICAO")]
        public bool Repeticao { get; set; }
        
        [Column("QDADE_REPETICAO")]
        public int QdadeRepeticao { get; set; }
        
        [Column("OBSERVACOES")]
        public string? Observacoes { get; set; }
        
        [Column("TAGS")]
        [ForeignKey("ID")]
        public List<Tags>? Tags { get; set; }
    }
}