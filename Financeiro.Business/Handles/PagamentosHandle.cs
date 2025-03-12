using Financeiro.Business.Commands;


namespace Financeiro.Api.Handle;

//concret command 

public class PagamentosHandle : Command
{
    private Business.Handles.PagamentoAcao PagtoAcao { get; set; }  //criando vinculo cocm receiver
    private double Valor { get; set; }

    public PagamentosHandle(Business.Handles.PagamentoAcao pgtoacao, double valor)
    {
        PagtoAcao = pgtoacao;
        Valor = valor;
    }

    public override void Executar()  //executar as ações de pagamento
    {
        //    if ("Pagar")
        //    {
        //        PagtoAcao.RealizarPagamento(Valor);
        //    }

        //    if ("Receber")
        //    {

        //    }
    }


}

