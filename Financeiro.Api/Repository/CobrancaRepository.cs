using Financeiro.Api.Data;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Repository;

public class CobrancaRepository : ICobrancas
{
    private readonly ApiDbcontext _context;
    public CobrancaRepository(ApiDbcontext context)
    {
        _context = context;
    }
    public string Link { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void AlterarDataVencimento(string idcobranca, DateTime DataAlteracao)
    {
        throw new NotImplementedException();
    }

    public CancelamentoCobranca CancelarCobranca(string idcobranca)
    {
        throw new NotImplementedException();
    }

    public RetornoPix CobrancaPix(string pix)
    {
        throw new NotImplementedException();
    }

    public void EnviarEmail(string idcobranca)
    {
        throw new NotImplementedException();
    }

    public RetornoCobranca GerarBoleto(Cobrancas cobranca)
    {
        throw new NotImplementedException();
    }

    public RetornoCobranca GerarBoletoNegociacao(Cobranca_Negociacao cobranca)
    {
        throw new NotImplementedException();
    }

    public RetornoCobranca GerarCobrancaCredito(Cobrancas cobranca, string cartaoToken)
    {
        throw new NotImplementedException();
    }

    public void GetInformacaoCobranca(string idcobranca)
    {
        throw new NotImplementedException();
    }

    public Task GetNotificacoes(string idcobranca)
    {
        throw new NotImplementedException();
    }

    public byte[] GetPDF(string linhaDigitavel, long? idGateway, Cobrancas cobrancaFaturamento)
    {
        throw new NotImplementedException();
    }

    public string TokenizaCartao(string numeroCartao, string mesVencimento, string anoVencimento, string codSeguranca, string nomeCartao, string bandeira)
    {
        throw new NotImplementedException();
    }
}
