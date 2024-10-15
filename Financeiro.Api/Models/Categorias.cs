using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Financeiro.Api.Models.Base;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Api.Models
{    
    [Table("TB_CATEGORIAS")]
    public class Categorias : BaseModel
    {
        
        [Column("DESCRICAO")]
        [Required]        
        [StringLength(maximumLength:600,ErrorMessage ="Campo Obrigatório")]
        public string? Descricao { get; set; } 
        
        [Column("TIPOCATEGORIA")]  
        [Required]
        public TipoCategoria tipoCategoria {get;set;}
               

    }
}