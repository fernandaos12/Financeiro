using Financeiro.Domain.Enums;

namespace Financeiro.Api.Models.DTO
{
    public class CategoriaDTO
    {
        public string? Descricao { get; set; }
        public TipoCategoria tipoCategoria { get; set; }
        public string? CorGrafico { get; set; } = "#FFF";
        public ICollection<ContasPagarDTO> ContasPagar { get; set; } = new List<ContasPagarDTO>();
        public Domain.Enums.Status_Default Status { get; internal set; }
    }
}
