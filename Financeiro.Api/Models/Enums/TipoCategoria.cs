using System.Text.Json.Serialization;

namespace Financeiro.Api.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TipoCategoria
{
    Habitacao = 1,
    Educacao = 2,
    Saude = 3,
    Compras = 4,
    Supermercado = 5,
    Alimentacao = 6,
    Vestuario = 7,
    Lazer = 8,
    Transporte = 9,
    Salário = 10,
    Extras = 11

}
