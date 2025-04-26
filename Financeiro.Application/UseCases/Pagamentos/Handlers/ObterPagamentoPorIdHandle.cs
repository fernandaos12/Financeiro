using Financeiro.Api.Repository;
using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Pagamentos.Queries;
using Financeiro.Application.UseCases.Response;
using MediatR;

namespace Financeiro.Application.UseCases.Pagamento.Handles
{
    public sealed class ObterPagamentoPorIdHandle(PagamentosRepository repository) : IRequestHandler<ObterPagamentoPorIdQuery, Result<PagamentoDTO>>
    {
        public async Task<Result<PagamentoDTO>> Handle(ObterPagamentoPorIdQuery request, CancellationToken cancellationToken)
        {
            await repository.FindId(request.Id);
            return new Result<PagamentoDTO>(new PagamentoDTO { Id = request.Id });
        }
    }
}
