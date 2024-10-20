using System.Text.Json.Serialization;

namespace Financeiro.Api.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Status_Default
    {
        Ativo = 1,
        Inativo = 2,
    }
}