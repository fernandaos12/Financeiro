using Financeiro.Api.Repository;
using Financeiro.Application.UseCases.Pagamentos.Commands;
using Financeiro.Application.UseCases.Response;
using MediatR;

namespace Financeiro.Application.UseCases.Pagamento.Handles
{
    public sealed class RemoverPagamentoHandle(PagamentosRepository repository) : IRequestHandler<RemoverPagamentoCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(RemoverPagamentoCommand request, CancellationToken cancellationToken)
        {
            await repository.Remover(request.Id);
            return new Result<bool>(true);
        }
    }
}
