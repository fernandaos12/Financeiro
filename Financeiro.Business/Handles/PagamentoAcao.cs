
using Financeiro.Api.Models;
using Financeiro.Api.Models.Enums;
using Financeiro.Business.Models;

namespace Financeiro.Business.Handles
{
    //receiver
    public class PagamentoAcao
    {
        public double RealizarPagamento(double valor)
        {
            var desconto = new Desconto();
            desconto.Valor = 0.1;

            double total = valor - desconto.Valor;
            var pgto = new Pagamento()
            {
                DataPagamento = DateTime.Now,
                Valor = total,
                StatusPagamento = StatusConta.Pago
            };

            return total;
        }

        public bool CancelarPagamento(Pagamento obj)
        {
            obj.StatusPagamento = StatusConta.Cancelado;
            return true;
        }

        public double RealizarPagamentoAcrecimo(double valorPagamento, int qdadeDiasAtraso)
        {
            var acrescimos = new AcrescimosConta();

            acrescimos.juros = 0.1 * qdadeDiasAtraso;
            acrescimos.multa = 0.2 * qdadeDiasAtraso;

            return acrescimos.valorTotal = valorPagamento + acrescimos.juros + acrescimos.multa;
        }

        public double SaldoDevedor(double valorDebito, double valorPgto)
        {
            double saldoDevedor = valorDebito < valorPgto ? valorDebito - valorPgto : 0;
            return saldoDevedor;
        }
    }
}
