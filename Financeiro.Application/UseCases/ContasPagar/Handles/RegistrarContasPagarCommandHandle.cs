using Financeiro.Application.UseCases.ContasPagar.Commands;
using Financeiro.Application.UseCases.Response;
using Financeiro.Domain.Repository;
using MediatR;

namespace Financeiro.Application.UseCases.ContasPagar.Handles;
public sealed class RegistrarContasPagarHandler(IContasPagarRepository _repo)
    : IRequestHandler<RegistrarContasPagarCommand, Result<string>>
{
    public async Task<Result<string>> Handle(RegistrarContasPagarCommand request, CancellationToken cancellationToken)
    {
        var item = new Domain.Entities.ContasPagar
        {
            Descricao = request.contas.Descricao,
            Data_Vencimento = request.contas.Data_Vencimento,
            Valor = request.contas.Valor,
            Observacao = request.contas.Observacao,
            Status = request.contas.Status,
            DataAlteracao = DateTime.Now,
            Status_Conta = request.contas.Status_Conta,
            ValorPago = request.contas.ValorPago,
            Categoria = request.contas.Categoria,
            Repeticao = request.contas.Repeticao,
            Periodicidade = request.contas.Periodicidade,
            ValorParcela = request.contas.ValorParcela,
            NumeroParcelas = request.contas.NumeroParcelas,
            CaminhoAnexos = request.contas.CaminhoAnexos,
            Anexos = request.contas.Anexos,
            PagamentoId = null,
            SaldoDevedorAtualizado = request.contas.SaldoDevedorAtualizado,
            Tags = request.contas.Tags ?? new List<string>(),
        };
        await _repo.Salvar(item);

        var resultado = new Result<string>("Sucesso, conta a pagar criado.");

        return resultado;
    }
}



//public sealed class ContasPagarHandle(IContasPagarRepository repository) : IRequestHandler<Command, Result<Response>>
//{
//    public async Task<Result<Response>> Handle(Command request, CancellationToken cancellationToken)
//    {
//        var conta = await repository.FindId(request.Id);
//        return conta is null
//            ? Result.Failure<Response>(new Error("404", "Não encontrado"))
//            : Result.Success<Response>(new Response(conta.Id, conta.Descricao));
//    }
//}

//public sealed class RegistrarContasPagarHandler(IContasPagarRepository _repo) 
//    : IRequestHandler<RegistrarContasPagarCommand, Result<Response>>
//{
//    public async Task<Result<Response>> Handle(RegistrarContasPagarCommand request, CancellationToken cancellationToken)
//    {
//        await _repo.Salvar(request.ContasAPagar);
//        return new Response(true, "Sucesso, conta a pagar criado.");
//    }
//}