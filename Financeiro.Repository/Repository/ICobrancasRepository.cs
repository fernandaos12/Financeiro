using Financeiro.Domain.Entities;

namespace Financeiro.Domain.Repository;
public interface ICobrancasRepository
{
    Task<string> GerarBoleto(Cobrancas cobranca);
    Task<string> GerarCobrancaCredito(Cobrancas cobranca, string cartaoToken);
    Task<string> GerarBoletoNegociacao(Cobranca_Negociacao cobranca);
    Task<string> GerarPix(string pix);
    string TokenizaCartao(string numeroCartao, string mesVencimento, string anoVencimento, string codSeguranca, string nomeCartao, string bandeira);
    Task GetNotificacoes(string idcobranca);
    Task<bool> CancelarCobranca(string idcobranca);
    void AlterarDataVencimento(string idcobranca, DateTime DataAlteracao);
    void GetInformacaoCobranca(string idcobranca);
    void EnviarEmail(string idcobranca);
    byte[] GetPDF(string linhaDigitavel, Int64? idGateway, Cobrancas cobrancaFaturamento);

}

