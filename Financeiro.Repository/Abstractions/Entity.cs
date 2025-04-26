using Financeiro.Domain.Enums;

namespace Financeiro.Domain.Abstractions
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public Status_Default Status { get; set; } = Status_Default.Ativo;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}
