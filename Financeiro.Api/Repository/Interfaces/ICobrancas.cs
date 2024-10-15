using System;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Models;
using Microsoft.Net.Http.Headers;

namespace Financeiro.Api.Repository.Interfaces;

public interface ICobrancas
{
    string Link { get; set; }
    RetornoCobranca GerarBoleto(Cobrancas cobranca);
    RetornoCobranca GerarCobrancaCredito(Cobrancas cobranca,string cartaoToken);
    RetornoCobranca GerarBoletoNegociacao(Cobranca_Negociacao cobranca);
    string TokenizaCartao(string numeroCartao,string mesVencimento,string anoVencimento,string codSeguranca,string nomeCartao,string bandeira);
    Task GetNotificacoes(string idcobranca);
    CancelamentoCobranca CancelarCobranca(string idcobranca);
    void AlterarDataVencimento(string idcobranca,DateTime DataAlteracao);
    void GetInformacaoCobranca(string idcobranca);
    void EnviarEmail(string idcobranca);
    byte[] GetPDF(string linhaDigitavel, Int64? idGateway, Cobrancas cobrancaFaturamento);
    RetornoPix CobrancaPix(string pix);

 
}
