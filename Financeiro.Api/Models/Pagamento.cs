using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Api.Models.Base;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Api.Models
{
    [Table("TB_PAGAMENTO")]
    public class Pagamento : BaseModel
    {

        [Column("DESCRICAO")]
        [Required]
        public string? Descricao { get; set; }

        [Column("MES_COMPETENCIA")]
        [DataType(DataType.Date)]
        [Required]
        public MesCompetencia? MesCompetencia { get; set; }

        [Column("FORMA_PAGAMENTO")]
        [EnumDataType(typeof(TipoConta))]
        public TipoConta FormaPagamento { get; set; }

        [Column("PAGTO_PARCIAL")]
        public bool PagamentoParcial { get; set; } = false;

        [Column("VALOR_PAGTO_PARCIAL")]
        public double ValorPagamentoParcial { get; set; } = 0;

        [Column("SALDO_DEVEDOR")]
        public double SaldoDevedor { get; set; } = 0;

        [Column("ID_CONTA_PAGAR")]
        [ForeignKey("ID_CONTAPAGAR")]
        public ICollection<ContasPagar>? Id_ContaPagar { get; set; }
    }
}