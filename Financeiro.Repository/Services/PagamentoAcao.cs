using Financeiro.Domain.Entities;
using Financeiro.Domain.Enums;

namespace Financeiro.Domain.Services
{
    //receiver
    public class PagamentoAcao
    {
        private readonly Pagamento? _pagamento;
        private readonly ContasPagar? _contaspagar;

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

            return acrescimos.valorTotal = (int)(valorPagamento + acrescimos.juros + acrescimos.multa);
        }

        public double SaldoDevedor(double valorDebito, double valorPgto)
        {
            double saldoDevedor = valorDebito < valorPgto ? valorDebito - valorPgto : 0;
            return saldoDevedor;
        }

        public void Executar()
        {
            int diasAtraso = (DateTime.Now.Date - _contaspagar.Data_Vencimento).Days;

            if (_pagamento.Valor == _contaspagar.Valor && _contaspagar.Data_Vencimento <= DateTime.Now.Date)
            {
                // _pgtoAcao.RealizarPagamento(_contaspagar.Valor);
            }

            //if (diasAtraso > 0)
            //{
            //    _pgtoAcao.RealizarPagamentoAcrecimo(_contaspagar.Valor);
            //    _pagamento.StatusPagamento = StatusConta.Pago;
            //}
        }
    }

    public class Desconto
    {
        public Desconto()
        {
        }

        public double Valor { get; internal set; }
    }

    public class AcrescimosConta
    {
        internal int valorTotal;
        internal double juros;
        internal double multa;

        public AcrescimosConta()
        {
        }
    }
}
