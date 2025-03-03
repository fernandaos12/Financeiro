using System.Net;
using Financeiro.Api.Models.Enums;
using Financeiro.Api.Repository;
using Financeiro.Api.Repository.Interfaces;

namespace Financeiro.Api.Handle;

public class PagamentosHandle : Notifiable, IHandler<IPagamemtoCommand>
{
    private readonly IPagamentos _pagamentosrepository;
    private readonly IContaPagar _contapagarrepository;
    private readonly IDescontos _descontosrepository;
    private readonly IAcrecimosConta _acrescimosrepository;

    public PagamentosHandle(
        IPagamentos pagamentosrepository,
        IContasPagar contaspagarrepository,
        IDescontos descontosrepository,
        IAcrescimos acrescimosrespository)
    {
        pagamentosrepository = _pagamentosrepository;
        contaspagarrepository = _contapagarrepository;
        descontosrepository = _descontosrepository;
        acrescimosrespository = _acrescimosrepository;
    }

    public ICommandHandle Handle(PagamentoComando comando)
    {
        //fail fast validation
        comando.Validate();
        if (comando.Invalid)
        {
            return GenericCommandResult(false, "Pagamento Invalido", null);
        }

        Double ValorFinal = 0;
        // # 1 - recuperar a conta do mes selecionada
        var contaApagar = _contapagarrepository.ObterConta(comando.ContaId);
        var pagamento = pagamentosrepository.ObterPagamento(comando.ContaId);

        // # 2 - calcula atualizando valor total com juros e multas
        var descontos = _descontosrepository.ObterDescontos(comando.ContaId);
        var acrescimos = _acrescimosrepository.ObterAcrescimos();
        if (contaApagar.vencimento > DateTime.Now)
        {
            //valor da conta + acrescimo  
            ValorFinal = contaApagar.valorTotal + acrescimos.total;
            contaApagar.valorTotal = ValorFinal;
        }

        // # 3 - verificar tipo de pagamento disponivel recuperarndo do banco
        var tipoPagamento = pagamentosrepository.Select(p => p.TipoPagamento = contaApagar.tipoPagamento);

        // # 4 - fazer o pagamento dando baixa na conta a pagar 
        var pgtoConnect = WebRequestMethods.Http.client.connect();
        
        // 5 - agrupar notificacoes
        AdicionarNotificacao(pagamento.notificacao);

        if (invalid)
        {
            return new GenericCommandResult(false, "Falha ao realizar pagamento", Notificacao.Default);
        }
        if (pgtoConnect)
        {
            contaApagar.status = StatusConta.Pago;
            _contapagarrepository.save(contaApagar);
            pagamentosrepository.save(pagamento);
        }
        
        return new GenericCommandResult(true, $"Pagamento {contaApagar.descricao} realizado com sucesso", Notifications.Default);
    }
}