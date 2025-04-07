using Financeiro.Api.Models;
using Financeiro.Business.Commands.Interface;

namespace Financeiro.Business.Handles
{
    //concret command 

    public class PagamentosCommand : ICommand
    {
        private readonly Pagamento _pagamento;
        private readonly ContasPagar _contaspagar;
        private readonly PagamentoAcao _pgtoAcao;

        public PagamentosCommand(Pagamento pagamento, ContasPagar contaspagar, PagamentoAcao pgtoAcao)
        {
            _pagamento = pagamento;
            _contaspagar = contaspagar;
            _pgtoAcao = pgtoAcao;

        }

        public void Executar()
        {
            int diasAtraso = (DateTime.Now.Date - _contaspagar.Data_Vencimento).Days;

            if (_pagamento.Valor == _contaspagar.Valor && _contaspagar.Data_Vencimento <= DateTime.Now.Date)
            {
                _pgtoAcao.RealizarPagamento(_contaspagar.Valor);
            }

            //if (diasAtraso > 0)
            //{
            //    _pgtoAcao.RealizarPagamentoAcrecimo(_contaspagar.Valor);
            //    _pagamento.StatusPagamento = StatusConta.Pago;
            //}
        }
    }
}