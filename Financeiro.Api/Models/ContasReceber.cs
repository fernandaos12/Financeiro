
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Api.Models.Base;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Api.Models
{
    [Table("TB_CONTAS_RECEBER")]
    public class ContasReceber : BaseModel
    {
        [Column("DESCRICAO")]
        [Required]
        [StringLength(maximumLength: 500, ErrorMessage = "Campo Descrição obrigatório")]
        public string? Descricao { get; set; }

        [Column("VALOR")]
        [Required]
        public double Valor { get; set; }

        [Column("DATA_RECEBIMENTO")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DataRecebimento { get; set; }

        [Column("REPETICAO")]
        [Required]
        public bool Repeticao { get; set; }

        [Column("CONFIRMADO")]
        public bool Confirmado { get; set; }

        [Column("CONTA")]
        [EnumDataType(typeof(TipoConta))]
        public TipoConta? Conta { get; set; } //se a conta é de cartao de credito

        [Column("ID_CATEGORIA_RECEITAS")]
        public CategoriaReceitas? CategoriaReceitas { get; set; }

        [Column("OBSERVACOES")]
        public string? Observacoes { get; set; }

        [Column("COR_GRAFICO")]
        public string? CorGrafico { get; set; }

        [Column("CAMINHO_ANEXOS")]
        public String? CaminhoAnexos { get; set; } = String.Empty;

        [Column("ANEXOS")]
        public Byte[]? Anexos { get; set; }

    }
}