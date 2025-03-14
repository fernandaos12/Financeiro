using System;
using System.Text.Json.Serialization;

namespace Financeiro.Api.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TipoConta
{
    Carteira = 1,
    Cartao_Credito = 2,
    Debito = 3,
    Dinheiro = 4,
    ValeAlimentacao = 5,
    ValeRefeicao = 6,
    ValeCombustivel = 7,
    ValeGeral = 8,
    CripotoMoedas = 9

}
