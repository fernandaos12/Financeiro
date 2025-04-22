namespace Financeiro.Domain.Services
{
    public class PagamentoOrderService
    {
        public PagamentoOrderService(decimal valorPagamento, decimal desconto, decimal multa, decimal juros)
        {
            CodigoPgto = CodigoPagamento();
            valorPagamento = this.ValorPagamento;
            desconto = this.Desconto;
            multa = this.Multa;
            juros = this.Juros;

            Services = new List<PagamentoService>();
        }

        public int IdPagamento { get; private set; }
        public decimal ValorPagamento { get; private set; }
        public decimal ValorTotalPagamento { get; private set; }
        public decimal Desconto { get; private set; }
        public decimal Multa { get; private set; }
        public decimal Juros { get; private set; }
        public string? Status { get; private set; }
        public string? CodigoPgto { get; private set; }
        public List<PagamentoService> Services { get; private set; }



        public void ValorFinalPagamento(List<ContasPagarService> contaspagarservices)
        {
            foreach (var item in contaspagarservices)
            {
                if (item.DataVencimento > DateTime.Now)
                {
                    var precoTotal = item.Valor * Desconto;
                }
                //var total = Services.total * Desconto;

                //Services.Add(item, precoTotal)
            }


        }

        private string? CodigoPagamento()
        {
            const string numero = "0123456789";
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var codigo = new Char[10];
            var random = new Random();

            for (var i = 0; i < 10; i++)
            {
                codigo[i] = chars[random.Next(chars.Length)];
            }
            for (var i = 0; i < 10; i++)
            {
                codigo[i] = numero[random.Next(numero.Length)];
            }
            return new String(codigo);
        }
    }
}
