using System.Text.Json.Serialization;

namespace Financeiro.Api.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TipoReceita
{
    Salario = 1,
    Extra = 2,
    Pagamento = 3,
    Beneficios = 4,
    ValeRefeicao = 5,
    ValeAlimentacao = 6



}
