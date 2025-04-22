using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.ContasPagar.Responses;
using Financeiro.Domain.Repository;
using MediatR;

namespace Financeiro.Application.UseCases.ContasPagar.Handles
{
    public class ObterContaPorIdHandle(IContasPagarRepository repo)
        : IRequestHandler<ObterContaPorIdQuery, Result<ContasPagarDTO>>
    {
        public async Task<Result<ContasPagarDTO>> Handle(ObterContaPorIdQuery request, CancellationToken cancellationToken)
        {
            var conta = await repo.FindId(request.id);
            if (conta == null)
            {
                throw new ArgumentException("Conta nao encontrada");
            }

            return new Result<ContasPagarDTO>(new ContasPagarDTO { Id = conta.Id });
        }
    }
}
