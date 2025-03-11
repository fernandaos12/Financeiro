using Financeiro.Api.Models;

namespace Financeiro.Api.Services
{
    public class PagamentosService  //client
    {
        public async Task<bool> Pagar(ContasPagar contapagar, decimal valor)
        {
            //receiver
            PagamentoAcao receberPgto = new PagamentoAcao();

            PagamentosHandle handlepgto = new PagamentosHandle(receberPgto, valor);
            InvokerPagamento pgtoinvoker = new InvokerPagamento(handlepgto); //invoker 
            pgtoinvoker.Executar();

        }
    }
}
