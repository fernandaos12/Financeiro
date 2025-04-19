using Financeiro.Domain.Enums;

namespace Financeiro.Api.Models.Base
{
    public class BaseModel
    {
        public int Id { get; set; }

        public DateTime DataAlteracao { get; set; } = DateTime.Now;

        public Status_Default Status { get; set; } = Status_Default.Ativo;
    }
}