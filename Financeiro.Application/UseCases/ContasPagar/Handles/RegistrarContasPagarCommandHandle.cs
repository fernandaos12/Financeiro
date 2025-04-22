using Financeiro.Application.UseCases.ContasPagar.Commands;
using Financeiro.Application.UseCases.ContasPagar.Responses;
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
            Descricao = request.ContasAPagar.Descricao,
            Data_Vencimento = request.ContasAPagar.Data_Vencimento,
            Valor = request.ContasAPagar.Valor,
            Observacao = request.ContasAPagar.Observacao,
            Status = request.ContasAPagar.Status,
            DataAlteracao = DateTime.Now,
            Status_Conta = request.ContasAPagar.Status_Conta,
            ValorPago = request.ContasAPagar.ValorPago,
            Categoria = request.ContasAPagar.Categoria,
            Repeticao = request.ContasAPagar.Repeticao,
            Periodicidade = request.ContasAPagar.Periodicidade,
            ValorParcela = request.ContasAPagar.ValorParcela,
            NumeroParcelas = request.ContasAPagar.NumeroParcelas,
            CaminhoAnexos = request.ContasAPagar.CaminhoAnexos,
            Anexos = request.ContasAPagar.Anexos,
            PagamentoId = request.ContasAPagar.PagamentoId,
            SaldoDevedorAtualizado = request.ContasAPagar.SaldoDevedorAtualizado,
            Tags = request.ContasAPagar.Tags ?? new List<string>(),
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