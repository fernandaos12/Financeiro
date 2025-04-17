using Financeiro.Domain.Services;

namespace Financeiro.Application.InputModels
{
    public class PagamentoView
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public PagamentoService PagamentoTotal()
            => new PagamentoService(Descricao, Valor, Vencimento, DataPagamento);

        public static PagamentoOrderService PagamentoFinal(PagamentoService pgto)
        {
            var dadospgto = PagamentoService.PagamentoFinal;
            return new PagamentoOrderService(
                dadospgto.Descricao,
                dadospgto.Valor,
                dadospgto.Vencimento,
                dadospgto.DataPagamento);
        }

    }

}