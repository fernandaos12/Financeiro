using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Api.Models.Base;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Api.Models
{
    [Table("TB_CATEGORIA_RECEITAS")]
    public class CategoriaReceitas : BaseModel
    {

        [Column("DESCRICAO")]
        [Required]
        [StringLength(maximumLength: 600, ErrorMessage = "Campo Obrigatório")]
        public string? Descricao { get; set; }

        [Column("TIPOCATEGORIA")]
        [Required]
        [EnumDataType(typeof(TipoCategoria))]
        public TipoCategoria tipoCategoria { get; set; }

        [Column("COR_GRAFICO")]
        public string? CorGrafico { get; set; } = "#FFF";

    }
}