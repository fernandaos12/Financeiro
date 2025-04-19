using Financeiro.Api.Models.Base;

namespace Financeiro.Api.Models.DTO
{
    public class ConfiguracoesDTO : BaseModel
    {
        public string Nome { get; internal set; }
        public object Valor { get; internal set; }
    }
}
