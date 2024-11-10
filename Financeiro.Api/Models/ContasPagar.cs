using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Api.Models.Base;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Api.Models
{
    [Table("TB_CONTAS_PAGAR")]
    public class ContasPagar : BaseModel
    {
        private double _saldoDevedor;

        [Column("DESCRICAO")]
        [Required]
        [StringLength(maximumLength: 500, ErrorMessage = "Campo Descrição obrigatório")]
        public string? Descricao { get; set; }

        [Column("STATUS_CONTA")]
        [EnumDataType(typeof(StatusConta))]
        public StatusConta Status_Conta { get; set; }

        [Column("EMISSAO")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime Data_Emissao { get; set; }

        [Column("VENCIMENTO")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime Data_Vencimento { get; set; }

        [Column("PAGAMENTO")]
        [ForeignKey("ID_PAGAMENTO")]
        public Pagamento? Pagamento { get; set; }

        [Column("VALOR")]
        public double Valor { get; set; }

        [Column("PAGTO_PARCIAL")]
        public bool PagamentoParcial { get; set; } = false;

        [Column("VALOR_PAGTO_PARCIAL")]
        public double ValorPagamentoParcial { get; set; } = 0;

        [Column("SALDO_DEVEDOR")]
        public double SaldoDevedor
        {
            get => _saldoDevedor != 0 ? _saldoDevedor : 0;
            set
            {
                if (PagamentoParcial == true)
                {
                    _saldoDevedor = Valor - ValorPagamentoParcial;
                }

            }
        }

        [Column("CATEGORIA")]
        [ForeignKey("ID_CATEGORIA")]
        public Categorias? Categoria { get; set; }

        [Column("REPETICAO")]
        public bool Repeticao { get; set; } = false;

        [Column("QDADE_REPETICAO")]
        public int QdadeRepeticao { get; set; }

        [Column("OBSERVACOES")]
        public string? Observacoes { get; set; }

        [Column("TAGS")]
        [ForeignKey("ID_TAG")]
        public List<Tags>? Tags { get; set; }

        [Column("COR_GRAFICO")]
        public string? CorGrafico { get; set; }
    }
}