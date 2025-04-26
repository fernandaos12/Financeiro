using Financeiro.Domain.Enums;

namespace Financeiro.Application.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public Status_Default Status { get; set; } = Status_Default.Ativo;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}
