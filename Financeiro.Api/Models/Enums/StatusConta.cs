using System.Text.Json.Serialization;

namespace Financeiro.Api.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusConta
    {
        Pendente = 0,
        Pago = 1
    
    }
}