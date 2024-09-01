
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Api.Models.Base;

namespace Financeiro.Api.Models
{
    [Table("TB_CONFIGURACOES")]
    public class Configuracoes : BaseModel
    {
        [Column("NOME")]
        [Required]
        [StringLength(maximumLength:500,ErrorMessage ="Campo Descrição obrigatório")]
        public string?  Nome { get; set; }

        [Column("EMAIL")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string?  Email { get; set; }

        [Column("TELEFONE")]
        [DataType(DataType.PhoneNumber)]
        public int telefone { get; set; }

        [Column("RECEITAS")]
        [ForeignKey("ID")]
        public List<Receitas>? Receitas { get; set; }

        [Column("CARTAO_CREDITO")]
        [ForeignKey("ID")]
        public List<CartaoCredito>? CartaoCredito { get; set; }

        [Column("CONTABANCARIA")]
        [ForeignKey("ID")]
        public List<ContaBancaria>? ContasBancarias { get; set; }
    }
}