using Financeiro.Application.UseCases.ContasPagar.Commands;
using Financeiro.Application.UseCases.Response;
using Financeiro.Domain.Repository;
using MediatR;

namespace Financeiro.Application.UseCases.ContasPagar.Handles
{
    public class RemoverContaPagarHandle(IContasPagarRepository repo) : IRequestHandler<RemoverContaPagarCommand, Result<bool>>
    {
        public Task<Result<bool>> Handle(RemoverContaPagarCommand request, CancellationToken cancellationToken)
        {
            repo.Remover(request.id);

            return Task.FromResult(new Result<bool>(true));
        }
    }
}
