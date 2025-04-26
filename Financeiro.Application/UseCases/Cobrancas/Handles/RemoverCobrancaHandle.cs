using Financeiro.Application.UseCases.Cobrancas.Command;
using Financeiro.Application.UseCases.Response;
using Financeiro.Domain.Repository;
using MediatR;

namespace Financeiro.Application.UseCases.Cobrancas.Handles
{
    public sealed class RemoverPagamentoHandle(ICobrancasRepository repository) : IRequestHandler<RemoverCobrancaCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(RemoverCobrancaCommand request, CancellationToken cancellationToken)
        {
            await repository.ExcluirCobranca(request.Id);
            return new Result<bool>(true);
        }
    }
}
