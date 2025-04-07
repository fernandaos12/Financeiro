
namespace Financeiro.Business.Handles
{
    public class InvokerPagamento //invoker
    {
        private PagamentosCommand pagamentoHandle;

        public InvokerPagamento(PagamentosCommand pagamentoHandle)
        {
            this.pagamentoHandle = pagamentoHandle;
        }

        public bool Executar()
        {
            pagamentoHandle.Executar();
            return true;
        }
    }
}
