using Financeiro.Domain.Abstractions;
using MediatR;

namespace Financeiro.Application.UseCases.ContasPagar.GetById
{
    //manipulador
    public sealed class Handler(Domain.Repository.IContasPagarRepository repository)
            : IRequestHandler<Command, Result<Response>>
    {
        public async Task<Result<Response>> Handle(Command request, CancellationToken cancellationToken)
        {
            var conta = await repository.FindId(request.Id);
            return conta is null
                ? Result.Failure<Response>(new Error("404", "Não encontrado"))
                : Result.Success<Response>(new Response(conta.Id, conta.Descricao));
        }
    }
}
