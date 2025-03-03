using System.Diagnostics.Contracts;
using Financeiro.Api.Models;
using Financeiro.Business.Interfaces;
using Financeiro.Business.Models;
using Flunt.Notifications;
using Flunt.Validations;

namespace Financeiro.Business.Commands;

public class PagamentoCommand : Notifiable<Notification>, IPagamentoCommand
{
    public PagamentoCommand()
    {
        var itensContasPgtp = new List<GerarPagamento>();
    }

    public PagamentoCommand(IList<ContasPagar> contas_pagar, double valor, DateTime dataPagamento)
    {
        Valor = valor;
    }

    public string usuario { get; set; }
    public double Valor { get; set; }
    public DateTime dataPagamento { get; set; }
    public IList<ContasPagar> ItensContasPagar { get; set; }
    
    public void Validate()
    {
        AddNotifications(
            new Contract()
                .Requires()
                .HasLen(usuario, 11, "usuario", "usuario Invalido")
        );
    }
}



// public class EmailCommand : Notifiable<Notification>
// {
//     public EmailCommand(string enderecoEmail)
//     {
//         enderecoEmail = enderecoEmail;
//         AddNotification(new EmailContract(this));
//     }
//     public string enderecoEmail { get; set; }
// }