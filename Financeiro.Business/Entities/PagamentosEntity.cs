using System.Reflection.Metadata.Ecma335;

namespace Financeiro.Api.Entities;

public class PagamentosEntity
{
    public Desconto desconto { get; set; }
    public IList<contapagar> Itens { get; set; }
    
    public void AddItem(ContaPagar contapagar, Int32 quantidade)
    {
        var item = new Item(contapagar, quantidade);
        if (item.Valid)
        {
            pagamento.AddItem(item);
        }
    }
    
    public decimal TotalPagamento(double valor , DateTime vencimentoConta)
    {
        decimal total = 0;
        DateTime vencimento = vencimentoConta;
        foreach (var item in Itens)
        {
            total += item.Total;
            if (vencimento > DateTime.Today)
            {
                total -= Desconto != null ? Desconto.Value : 0;
            }
        }
        return total;
    }


    public void Pagar()
    {
        
    }
}