using Financeiro.Api.Models.Base;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Api.Models
{
    public class Categorias : BaseModel
    {
        public string? Descricao { get; set; }
        public TipoCategoria tipoCategoria { get; set; }
        public string? CorGrafico { get; set; } = "#FFF";
        public ICollection<ContasPagar> ContasPagar { get; set; } = new List<ContasPagar>();

    }
}