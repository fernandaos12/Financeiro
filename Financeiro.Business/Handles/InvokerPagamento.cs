using Financeiro.Api.Handle;

namespace Financeiro.Business.Handles
{
    public class InvokerPagamento //invoker
    {
        private PagamentosHandle pagamentoHandle;

        public InvokerPagamento(PagamentosHandle pagamentoHandle)
        {
            this.pagamentoHandle = pagamentoHandle;
        }

        public void Executar()
        {
            pagamentoHandle.Executar();
        }
    }
}
