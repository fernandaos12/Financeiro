using Financeiro.Api.Models.Enums;

namespace Financeiro.Api.Models.DTO
{
    public class CategoriaDTO
    {
        public string? Descricao { get; set; }
        public TipoCategoria tipoCategoria { get; set; }
        public string? CorGrafico { get; set; } = "#FFF";
        public ICollection<ContasPagarDTO> ContasPagar { get; set; } = new List<ContasPagarDTO>();
    }
}
