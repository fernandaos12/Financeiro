using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Api.Models.Base
{
    public class BaseModel
    {
        [Key]
        [Column("ID")]
         public int Id { get; set; }
        
        [Column("DATA_ALTERACAO")]
        public DateTime DataAlteracao { get; set; } = DateTime.Now;

        [Column("STATUS")]
        public Status_Default Status { get; set; } = Status_Default.Ativo;
    }
}