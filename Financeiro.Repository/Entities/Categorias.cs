using Financeiro.Domain.Abstractions;
using Financeiro.Domain.Enums;

namespace Financeiro.Domain.Entities;

public class Categorias : Entity
{
    public string? Descricao { get; set; }
    public TipoCategoria TipoCategoria { get; set; }
    public string? CorGrafico { get; set; } = "#FFF";

}