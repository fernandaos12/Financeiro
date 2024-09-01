using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
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
        [Required]
        [JsonConverter(typeof(MesCompetencia))]
        public MesCompetencia? MesCompetencia { get; set; }

        [Column("FORMA_PAGAMENTO")]
        [Required]
        [JsonConverter(typeof(TipoConta))]
        public TipoConta FormaPagamento { get; set; }

        [Column("DATA_FECHAMENTO")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataFechamento { get; set; }

    } 
}