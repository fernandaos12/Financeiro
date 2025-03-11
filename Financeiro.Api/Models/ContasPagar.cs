using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Api.Models.Base;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Api.Models
{
    [Table("TB_CONTAS_PAGAR")]
    public class ContasPagar : BaseModel
    {
        [Column("DESCRICAO")]
        [Required]
        [StringLength(maximumLength: 500, ErrorMessage = "Campo Descrição obrigatório")]
        public string? Descricao { get; set; }

        [Column("STATUS_CONTA")]
        [EnumDataType(typeof(StatusConta))]
        public StatusConta Status_Conta { get; set; } = StatusConta.Pendente;

        [Column("VENCIMENTO")]
        [DataType(DataType.Date)]
        public DateTime Data_Vencimento { get; set; } = DateTime.Now;

        [Column("VALOR")]
        public double Valor { get; set; }

        [Column("CATEGORIA")]
        [ForeignKey("ID_CATEGORIA")]
        public CategoriaReceitas? Categoria { get; set; }

        [Column("CATEGORIAID")]
        public int? CategoriaId { get; set; }

        [Column("REPETICAO")]
        [EnumDataType(typeof(TipoRepeticao))]
        public TipoRepeticao Repeticao { get; set; } = TipoRepeticao.UNICO;

        [Column("PERIODICIDADE")] //MENSAL,ANUAL,SEMESTRAL
        [EnumDataType(typeof(Periodicidade))]
        public int? Periodicidade { get; set; }

        [Column("VALOR_PARCELA")]
        public int? ValorParcela { get; set; }

        [Column("NUMERO_PARCELAS")]
        public int? NumeroParcelas { get; set; }

        [Column("OBSERVACOES")]
        public string? Observacoes { get; set; }

        [Column("CAMINHO_ANEXOS")]
        public String? CaminhoAnexos { get; set; } = String.Empty;

        [Column("ANEXOS")]
        public Byte[]? Anexos { get; set; }

        [Column("ID_PAGAMENTOS")]
        public int PagamentoId { get; set; }
        public Pagamento? Pagamento { get; set; }

    }
}