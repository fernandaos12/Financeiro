using System.Reflection.Metadata.Ecma335;
using Financeiro.Api.Models;
using Financeiro.Business.Models;

namespace Financeiro.Api.Entities;

public class PagamentosEntity
{
    public Desconto desconto { get; set; }
    public IList<ContasPagar> Itens { get; set; }
    
    public void AddItem(ContasPagar contapagar, Int32 quantidade)
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
                total -= desconto != null ? Desconto.Value : 0;
            }
        }
        return total;
    }


    public void Pagar()
    {
        
    }
}