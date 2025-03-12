using Financeiro.Api.Handle;
using Financeiro.Api.Models;
using Financeiro.Business.Handles;

namespace Financeiro.Api.Services
{
    public class PagamentosService  //client
    {
        public bool Pagar(ContasPagar contapagar, double valor)
        {
            //receiver
            PagamentoAcao receberPgto = new PagamentoAcao();

            PagamentosHandle handlepgto = new PagamentosHandle(receberPgto, valor);
            InvokerPagamento pgtoinvoker = new InvokerPagamento(handlepgto); //invoker 
            pgtoinvoker.Executar();

            return true;
        }
    }
}
